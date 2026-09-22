using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WarsztatSamochodowy
{
    public partial class adminUsersForm : Form
    {
        private UserSession session;
        private DataTable usersTable = new DataTable();

        public adminUsersForm()
        {
            InitializeComponent();
            AppBranding.ApplyWindowIcon(this);
            this.EnableDoubleBuffering();
            dataGridView_users.EnableDoubleBuffering();
        }

        public adminUsersForm(UserSession session) : this()
        {
            this.session = session;
            if (session != null)
            {
                label_adminInfo.Text = "Zalogowany Administrator: " + session.PelnaNazwa + " (" + session.Login + ")";
            }
        }

        private void adminUsersForm_Load(object sender, EventArgs e)
        {
            // Weryfikacja uprawnień RBAC
            if (!SecurityHelper.HasPermission(session, "Administrator", "Admin"))
            {
                MessageBox.Show("Brak uprawnień administracyjnych do tego widoku!", "Odmowa dostępu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            comboBox_roleFilter.SelectedIndex = 0; // Wszyscy
            comboBox_nowaRola.SelectedIndex = 0;
            WczytajUzytkownikow();
        }

        private void WczytajUzytkownikow()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT Id, Login, Imie, Nazwisko, Email, Telefon, Rola, DataRejestracji, Adres 
                                     FROM Uzytkownicy 
                                     ORDER BY Id DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        usersTable = new DataTable();
                        adapter.Fill(usersTable);

                        dataGridView_users.DataSource = usersTable.DefaultView;
                        FiltrujUzytkownikow();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd wczytywania użytkowników: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrujUzytkownikow()
        {
            if (usersTable == null || usersTable.DefaultView == null)
                return;

            string search = (textBox_search.Text ?? string.Empty).Trim().Replace("'", "''");
            string role = comboBox_roleFilter.SelectedItem != null ? comboBox_roleFilter.SelectedItem.ToString() : "Wszyscy";

            List<string> filters = new List<string>();

            if (!string.IsNullOrEmpty(search))
            {
                filters.Add(string.Format("(Login LIKE '%{0}%' OR Imie LIKE '%{0}%' OR Nazwisko LIKE '%{0}%' OR Email LIKE '%{0}%')", search));
            }

            if (role != "Wszyscy" && !string.IsNullOrEmpty(role))
            {
                filters.Add(string.Format("Rola = '{0}'", role.Replace("'", "''")));
            }

            usersTable.DefaultView.RowFilter = string.Join(" AND ", filters);
            label_count.Text = "Łącznie użytkowników: " + usersTable.DefaultView.Count;
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            FiltrujUzytkownikow();
        }

        private void comboBox_roleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrujUzytkownikow();
        }

        private void dataGridView_users_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_users.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView_users.SelectedRows[0];
                string currentRole = row.Cells["Rola"].Value != null ? row.Cells["Rola"].Value.ToString() : "Klient";
                if (comboBox_nowaRola.Items.Contains(currentRole))
                {
                    comboBox_nowaRola.SelectedItem = currentRole;
                }
            }
        }

        private void button_zmienRole_Click(object sender, EventArgs e)
        {
            if (dataGridView_users.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika z listy.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dataGridView_users.SelectedRows[0];
            int targetId = Convert.ToInt32(row.Cells["Id"].Value);
            string targetLogin = row.Cells["Login"].Value.ToString();
            string newRole = comboBox_nowaRola.SelectedItem != null ? comboBox_nowaRola.SelectedItem.ToString() : "Klient";

            if (session != null && session.Id == targetId && newRole != "Administrator")
            {
                MessageBox.Show("Nie możesz odebrać sobie roli Administratora!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Uzytkownicy SET Rola = @rola WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rola", newRole);
                        cmd.Parameters.AddWithValue("@id", targetId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(string.Format("Zaktualizowano rolę dla użytkownika {0} na: {1}", targetLogin, newRole), "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WczytajUzytkownikow();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zmiany roli: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_resetHasla_Click(object sender, EventArgs e)
        {
            if (dataGridView_users.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika z listy, aby zresetować hasło.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dataGridView_users.SelectedRows[0];
            int targetId = Convert.ToInt32(row.Cells["Id"].Value);
            string targetLogin = row.Cells["Login"].Value.ToString();

            string tempPassword = "Warsztat" + new Random().Next(1000, 9999) + "!";
            DialogResult confirm = MessageBox.Show(
                string.Format("Czy na pewno chcesz zresetować hasło dla użytkownika {0}?\n\nNowe hasło tymczasowe: {1}", targetLogin, tempPassword),
                "Potwierdzenie resetu hasła",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string passwordHash = PasswordHelper.HashPassword(tempPassword);

                    using (SqlConnection conn = DbHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "UPDATE Uzytkownicy SET PasswordHash = @hash WHERE Id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@hash", passwordHash);
                            cmd.Parameters.AddWithValue("@id", targetId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Reset prób logowania w razie blokady
                    SecurityHelper.ResetFailedAttempts(targetLogin);

                    Clipboard.SetText(tempPassword);
                    MessageBox.Show(
                        string.Format("Hasło zostało zresetowane!\n\nUżytkownik: {0}\nNowe hasło: {1}\n\n(Hasło zostało skopiowane do Twojego schowka).", targetLogin, tempPassword),
                        "Reset hasła zakończony",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd resetowania hasła: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_usunKonto_Click(object sender, EventArgs e)
        {
            if (dataGridView_users.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika z listy do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dataGridView_users.SelectedRows[0];
            int targetId = Convert.ToInt32(row.Cells["Id"].Value);
            string targetLogin = row.Cells["Login"].Value.ToString();

            if (session != null && session.Id == targetId)
            {
                MessageBox.Show("Nie możesz usunąć własnego konta, na którym jesteś obecnie zalogowany!", "Niedozwolona operacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                string.Format("Czy na pewno chcesz bezpowrotnie usunąć konto użytkownika {0}?\nWszystkie przypisane pojazdy również zostaną usunięte.", targetLogin),
                "Potwierdzenie usunięcia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DbHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Uzytkownicy WHERE Id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", targetId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Konto użytkownika zostało usunięte.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WczytajUzytkownikow();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas usuwania konta: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm(session);
            this.Hide();
            main.Show();
        }
    }
}
