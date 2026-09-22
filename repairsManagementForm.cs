using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WarsztatSamochodowy
{
    public partial class repairsManagementForm : Form
    {
        private UserSession session;
        private DataTable repairsTable = new DataTable();
        private int selectedCarId = -1;

        public repairsManagementForm()
        {
            InitializeComponent();
            AppBranding.ApplyWindowIcon(this);
            this.EnableDoubleBuffering();
            dataGridView_repairs.EnableDoubleBuffering();
        }

        public repairsManagementForm(UserSession session) : this()
        {
            this.session = session;
            if (session != null)
            {
                label_userInfo.Text = session.OpisRoli + " • " + session.PelnaNazwa;
            }
        }

        private void repairsManagementForm_Load(object sender, EventArgs e)
        {
            // Weryfikacja uprawnień RBAC (tylko pracownik lub administrator)
            if (!SecurityHelper.HasPermission(session, "Administrator", "Admin", "Pracownik"))
            {
                MessageBox.Show("Moduł zarządzania naprawami jest dostępny wyłącznie dla pracowników i administratorów warsztatu.", "Odmowa dostępu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            comboBox_etapFilter.SelectedIndex = 0;
            comboBox_etap.SelectedIndex = 0;

            WczytajMechanikow();
            WczytajNaprawy();
        }

        private void WczytajMechanikow()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT Id, Imie + ' ' + Nazwisko AS Nazwa 
                                     FROM Uzytkownicy 
                                     WHERE Rola IN ('Pracownik', 'Administrator')
                                     ORDER BY Nazwisko, Imie";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        // Filtr na pasku narzędzi
                        comboBox_mechanikFilter.Items.Clear();
                        comboBox_mechanikFilter.Items.Add("Wszyscy");
                        foreach (DataRow row in dt.Rows)
                        {
                            comboBox_mechanikFilter.Items.Add(row["Nazwa"].ToString());
                        }
                        comboBox_mechanikFilter.SelectedIndex = 0;

                        // Wybór w edycji
                        comboBox_mechanik.DataSource = dt.Copy();
                        comboBox_mechanik.DisplayMember = "Nazwa";
                        comboBox_mechanik.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd wczytywania listy pracowników: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void WczytajNaprawy()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT s.Id,
                                            s.Marka + ' ' + s.Model AS Pojazd,
                                            s.NrRejestracyjny,
                                            ISNULL(u.Imie + ' ' + u.Nazwisko, 'Brak') AS Klient,
                                            s.Status,
                                            ISNULL(m.Imie + ' ' + m.Nazwisko, 'Nieprzypisany') AS Mechanik,
                                            ISNULL(s.KosztRobocizny, 0) AS KosztRobocizny,
                                            ISNULL(s.KosztCzesci, 0) AS KosztCzesci,
                                            ISNULL(s.KosztNaprawy, 0) AS KosztLaczny,
                                            s.Uwagi,
                                            s.PracownikId,
                                            s.DataPrzyjecia
                                     FROM Samochody s
                                     LEFT JOIN Uzytkownicy u ON s.KlientId = u.Id
                                     LEFT JOIN Uzytkownicy m ON s.PracownikId = m.Id
                                     ORDER BY s.Id DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        repairsTable = new DataTable();
                        adapter.Fill(repairsTable);

                        dataGridView_repairs.DataSource = repairsTable.DefaultView;
                        FiltrujNaprawy();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd wczytywania listy napraw: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrujNaprawy()
        {
            if (repairsTable == null || repairsTable.DefaultView == null)
                return;

            string search = (textBox_search.Text ?? string.Empty).Trim().Replace("'", "''");
            string stage = comboBox_etapFilter.SelectedItem != null ? comboBox_etapFilter.SelectedItem.ToString() : "Wszystkie";
            string mechanic = comboBox_mechanikFilter.SelectedItem != null ? comboBox_mechanikFilter.SelectedItem.ToString() : "Wszyscy";

            List<string> filters = new List<string>();

            if (!string.IsNullOrEmpty(search))
            {
                filters.Add(string.Format("(Pojazd LIKE '%{0}%' OR NrRejestracyjny LIKE '%{0}%' OR Klient LIKE '%{0}%' OR Mechanik LIKE '%{0}%')", search));
            }

            if (stage != "Wszystkie" && !string.IsNullOrEmpty(stage))
            {
                filters.Add(string.Format("Status = '{0}'", stage.Replace("'", "''")));
            }

            if (mechanic != "Wszyscy" && !string.IsNullOrEmpty(mechanic))
            {
                filters.Add(string.Format("Mechanik = '{0}'", mechanic.Replace("'", "''")));
            }

            repairsTable.DefaultView.RowFilter = string.Join(" AND ", filters);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            FiltrujNaprawy();
        }

        private void comboBox_etapFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrujNaprawy();
        }

        private void comboBox_mechanikFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrujNaprawy();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            WczytajNaprawy();
        }

        private void dataGridView_repairs_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_repairs.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView_repairs.SelectedRows[0];
                selectedCarId = Convert.ToInt32(row.Cells["Id"].Value);

                string carTitle = row.Cells["Pojazd"].Value.ToString() + " (" + row.Cells["NrRejestracyjny"].Value.ToString() + ")";
                label_carSelected.Text = "Zlecenie #" + selectedCarId + ": " + carTitle;

                string status = row.Cells["Status"].Value != null ? row.Cells["Status"].Value.ToString() : "Przyjęty";
                if (comboBox_etap.Items.Contains(status))
                    comboBox_etap.SelectedItem = status;

                if (row.Cells["PracownikId"].Value != DBNull.Value && comboBox_mechanik.DataSource != null)
                {
                    try
                    {
                        comboBox_mechanik.SelectedValue = Convert.ToInt32(row.Cells["PracownikId"].Value);
                    }
                    catch
                    {
                    }
                }

                decimal robocizna = row.Cells["KosztRobocizny"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["KosztRobocizny"].Value) : 0m;
                decimal czesci = row.Cells["KosztCzesci"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["KosztCzesci"].Value) : 0m;

                textBox_robocizna.Text = robocizna.ToString("F2");
                textBox_czesci.Text = czesci.ToString("F2");
                textBox_opis.Text = row.Cells["Uwagi"].Value != null ? row.Cells["Uwagi"].Value.ToString() : string.Empty;

                PrzeliczLacznyKoszt();
            }
        }

        private void Koszty_TextChanged(object sender, EventArgs e)
        {
            PrzeliczLacznyKoszt();
        }

        private decimal PrzeliczLacznyKoszt()
        {
            decimal rob = 0;
            decimal cz = 0;

            if (!string.IsNullOrWhiteSpace(textBox_robocizna.Text))
            {
                decimal.TryParse(textBox_robocizna.Text.Replace(".", ","), out rob);
            }

            if (!string.IsNullOrWhiteSpace(textBox_czesci.Text))
            {
                decimal.TryParse(textBox_czesci.Text.Replace(".", ","), out cz);
            }

            decimal total = rob + cz;
            label_sumaKoszt.Text = string.Format("Łączny koszt: {0:N2} PLN", total);
            return total;
        }

        private void button_zapiszZlecenie_Click(object sender, EventArgs e)
        {
            if (selectedCarId <= 0)
            {
                MessageBox.Show("Wybierz zlecenie z tabeli.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal robocizna = 0;
            decimal czesci = 0;

            if (!string.IsNullOrWhiteSpace(textBox_robocizna.Text))
            {
                if (!decimal.TryParse(textBox_robocizna.Text.Replace(".", ","), out robocizna) || robocizna < 0)
                {
                    MessageBox.Show("Podaj poprawny koszt robocizny.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(textBox_czesci.Text))
            {
                if (!decimal.TryParse(textBox_czesci.Text.Replace(".", ","), out czesci) || czesci < 0)
                {
                    MessageBox.Show("Podaj poprawny koszt części.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            decimal totalCost = robocizna + czesci;
            string status = comboBox_etap.SelectedItem != null ? comboBox_etap.SelectedItem.ToString() : "Przyjęty";
            object pracownikIdVal = comboBox_mechanik.SelectedValue != null ? comboBox_mechanik.SelectedValue : (object)DBNull.Value;
            string uwagi = textBox_opis.Text.Trim();

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Samochody 
                                     SET Status = @status,
                                         PracownikId = @pracownikId,
                                         KosztRobocizny = @robocizna,
                                         KosztCzesci = @czesci,
                                         KosztNaprawy = @totalCost,
                                         Uwagi = @uwagi,
                                         DataWydania = CASE WHEN @status = 'Wydany' THEN GETDATE() ELSE DataWydania END
                                     WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@pracownikId", pracownikIdVal);
                        cmd.Parameters.AddWithValue("@robocizna", robocizna);
                        cmd.Parameters.AddWithValue("@czesci", czesci);
                        cmd.Parameters.AddWithValue("@totalCost", totalCost);
                        cmd.Parameters.AddWithValue("@uwagi", (object)uwagi ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@id", selectedCarId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Zlecenie zostało pomyślnie zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WczytajNaprawy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu zlecenia: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_repairs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_repairs.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Gotowy do odbioru")
                {
                    e.CellStyle.BackColor = Color.FromArgb(6, 78, 59); // Deep Emerald
                    e.CellStyle.ForeColor = Color.FromArgb(167, 243, 208);
                    e.CellStyle.Font = new Font(dataGridView_repairs.Font, FontStyle.Bold);
                }
                else if (status == "W trakcie naprawy" || status == "Diagnostyka" || status == "Oczekiwanie na części")
                {
                    e.CellStyle.BackColor = Color.FromArgb(120, 53, 15); // Deep Amber
                    e.CellStyle.ForeColor = Color.FromArgb(254, 215, 170);
                    e.CellStyle.Font = new Font(dataGridView_repairs.Font, FontStyle.Bold);
                }
                else if (status == "Przyjęty")
                {
                    e.CellStyle.BackColor = Color.FromArgb(30, 58, 138); // Deep Blue
                    e.CellStyle.ForeColor = Color.FromArgb(191, 219, 254);
                }
                else if (status == "Wydany")
                {
                    e.CellStyle.BackColor = Color.FromArgb(51, 65, 85); // Slate
                    e.CellStyle.ForeColor = Color.FromArgb(203, 213, 225);
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
