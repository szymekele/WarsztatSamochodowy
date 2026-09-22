using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WarsztatSamochodowy
{
    public partial class userDataForm : Form
    {
        private UserSession session;

        public userDataForm()
        {
            InitializeComponent();
            AppBranding.ApplyWindowIcon(this);
            this.EnableDoubleBuffering();
        }

        public userDataForm(UserSession session) : this()
        {
            this.session = session;
            if (session != null)
            {
                label_uzytkownik.Text = session.OpisRoli;
                WczytajDaneUzytkownika(session.Login);
            }
        }

        public userDataForm(string imie, string nazwisko, string rola, string login)
            : this(new UserSession(imie, nazwisko, rola, login))
        {
        }

        private void userDataForm_Load(object sender, EventArgs e)
        {
        }

        private void WczytajDaneUzytkownika(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                return;

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Id, Imie, Nazwisko, Rola, Login, Email, Telefon, DataRejestracji, Adres FROM Uzytkownicy WHERE Login = @login";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["Id"]);
                                string imie = reader["Imie"].ToString();
                                string nazwisko = reader["Nazwisko"].ToString();
                                string rola = reader["Rola"].ToString();
                                string userLogin = reader["Login"].ToString();
                                string email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
                                string telefon = reader["Telefon"] != DBNull.Value ? reader["Telefon"].ToString() : string.Empty;
                                string datarejestracji = reader["DataRejestracji"] != DBNull.Value ? Convert.ToDateTime(reader["DataRejestracji"]).ToString("yyyy-MM-dd") : "-";
                                string adres = reader["Adres"] != DBNull.Value ? reader["Adres"].ToString() : string.Empty;

                                label_imieNazwiskoVal.Text = string.Format("{0} {1}", imie, nazwisko).Trim();
                                label_loginVal.Text = userLogin;
                                label_rolaVal.Text = rola;
                                label_datarejestracjiVal.Text = datarejestracji;

                                textBox_email.Text = email;
                                textBox_telefon.Text = telefon;
                                textBox_adres.Text = adres;

                                if (session != null)
                                {
                                    session.Id = id;
                                    session.Imie = imie;
                                    session.Nazwisko = nazwisko;
                                    session.Rola = rola;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nie znaleziono użytkownika o podanym loginie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z bazą danych! " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            string email = textBox_email.Text.Trim();
            string telefon = textBox_telefon.Text.Trim();
            string adres = textBox_adres.Text.Trim();

            if (!string.IsNullOrEmpty(email) && !email.Contains("@"))
            {
                MessageBox.Show("Podaj poprawny adres e-mail (musi zawierać znak @).", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = session != null ? session.Id : -1;
            if (userId <= 0 && session != null)
            {
                WczytajDaneUzytkownika(session.Login);
                userId = session.Id;
            }

            if (userId <= 0)
            {
                MessageBox.Show("Nie można zidentyfikować użytkownika w sesji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Uzytkownicy 
                                     SET Email = @email, 
                                         Telefon = @telefon, 
                                         Adres = @adres 
                                     WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", (object)email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@telefon", (object)telefon ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@adres", (object)adres ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@id", userId);

                        cmd.ExecuteNonQuery();
                    }
                }

                label_info.ForeColor = Color.FromArgb(52, 211, 153);
                label_info.Text = "Dane profilu zostały pomyślnie zaktualizowane!";
                MessageBox.Show("Dane profilu zostały pomyślnie zapisane w bazie danych.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                label_info.ForeColor = Color.FromArgb(248, 113, 113);
                label_info.Text = "Błąd zapisu danych.";
                MessageBox.Show("Błąd zapisu danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm(session);
            this.Hide();
            main.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy chcesz się wylogować?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                loginForm login = new loginForm();
                this.Hide();
                login.Show();
            }
        }
    }
}
