using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarsztatSamochodowy
{
    public partial class carForm : Form
    {
        private UserSession session;
        private DataTable carsTable = new DataTable();

        public carForm()
        {
            InitializeComponent();
            AppBranding.ApplyWindowIcon(this);
            this.EnableDoubleBuffering();
            dataGridView_cars.EnableDoubleBuffering();
        }

        public carForm(UserSession session) : this()
        {
            this.session = session;
            if (session != null)
            {
                label_uzytkownik.Text = session.OpisRoli;
            }
        }

        public carForm(string imie, string nazwisko, string rola, string login)
            : this(new UserSession(imie, nazwisko, rola, login))
        {
        }

        private void carForm_Load(object sender, EventArgs e)
        {
            comboBox_status.SelectedIndex = 0;
            WczytajSamochody();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm(session);
            this.Hide();
            main.Show();
        }

        private void label_uzytkownik_Click(object sender, EventArgs e)
        {
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

        private int PobierzIdUzytkownika(string login)
        {
            if (session != null && session.Id > 0)
                return session.Id;

            int id = -1;
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id FROM Uzytkownicy WHERE Login = @login", conn);
                cmd.Parameters.AddWithValue("@login", login);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    id = Convert.ToInt32(result);
                    if (session != null)
                        session.Id = id;
                }
            }
            return id;
        }

        private void WczytajSamochody()
        {
            try
            {
                bool isAdminOrWorker = session != null && session.CzyPracownikLubAdmin;
                int userId = session != null ? PobierzIdUzytkownika(session.Login) : -1;

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (isAdminOrWorker)
                    {
                        query = @"SELECT s.Id, s.Marka, s.Model, s.RokProdukcji, s.NrRejestracyjny, s.VIN, 
                                         s.DataPrzyjecia, s.DataWydania, s.Status, s.KosztNaprawy, s.Uwagi,
                                         ISNULL(u.Imie + ' ' + u.Nazwisko, 'Brak') AS Wlasciciel
                                  FROM Samochody s
                                  LEFT JOIN Uzytkownicy u ON s.KlientId = u.Id
                                  ORDER BY s.Id DESC";
                    }
                    else
                    {
                        query = @"SELECT s.Id, s.Marka, s.Model, s.RokProdukcji, s.NrRejestracyjny, s.VIN, 
                                         s.DataPrzyjecia, s.DataWydania, s.Status, s.KosztNaprawy, s.Uwagi
                                  FROM Samochody s
                                  WHERE s.KlientId = @id
                                  ORDER BY s.Id DESC";
                        cmd.Parameters.AddWithValue("@id", userId);
                    }

                    cmd.CommandText = query;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    carsTable = new DataTable();
                    adapter.Fill(carsTable);

                    dataGridView_cars.DataSource = carsTable.DefaultView;
                    FiltrujSamochody();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wczytywania listy pojazdów: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrujSamochody()
        {
            if (carsTable == null || carsTable.DefaultView == null)
                return;

            string search = (textBox_search.Text ?? string.Empty).Trim().Replace("'", "''");
            string status = comboBox_status.SelectedItem != null ? comboBox_status.SelectedItem.ToString() : "Wszystkie";

            List<string> filters = new List<string>();

            if (!string.IsNullOrEmpty(search))
            {
                filters.Add(string.Format("(Marka LIKE '%{0}%' OR Model LIKE '%{0}%' OR NrRejestracyjny LIKE '%{0}%' OR VIN LIKE '%{0}%')", search));
            }

            if (status != "Wszystkie" && !string.IsNullOrEmpty(status))
            {
                filters.Add(string.Format("Status = '{0}'", status.Replace("'", "''")));
            }

            carsTable.DefaultView.RowFilter = string.Join(" AND ", filters);
            label_count.Text = "Znaleziono pojazdów: " + carsTable.DefaultView.Count;
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            FiltrujSamochody();
        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrujSamochody();
        }

        private void button_dodajsamochod_Click(object sender, EventArgs e)
        {
            addCarForm addCar = new addCarForm(session);
            this.Hide();
            addCar.Show();
        }

        private void button_zmienStatus_Click(object sender, EventArgs e)
        {
            if (dataGridView_cars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz pojazd z tabeli, aby zmienić jego stan lub koszt.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dataGridView_cars.SelectedRows[0];
            int carId = Convert.ToInt32(row.Cells["Id"].Value);
            string carInfo = row.Cells["Marka"].Value + " " + row.Cells["Model"].Value + " (" + row.Cells["NrRejestracyjny"].Value + ")";
            string currentStatus = row.Cells["Status"].Value != null ? row.Cells["Status"].Value.ToString() : "Przyjęty";
            
            decimal currentCost = 0;
            if (row.Cells["KosztNaprawy"].Value != null && row.Cells["KosztNaprawy"].Value != DBNull.Value)
            {
                decimal.TryParse(row.Cells["KosztNaprawy"].Value.ToString(), out currentCost);
            }

            string currentNotes = row.Cells["Uwagi"].Value != null ? row.Cells["Uwagi"].Value.ToString() : string.Empty;

            using (editStatusForm editForm = new editStatusForm(carId, carInfo, currentStatus, currentCost, currentNotes))
            {
                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    WczytajSamochody();
                }
            }
        }

        private void button_usunSamochod_Click(object sender, EventArgs e)
        {
            if (dataGridView_cars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz pojazd z tabeli, aby go usunąć.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dataGridView_cars.SelectedRows[0];
            int carId = Convert.ToInt32(row.Cells["Id"].Value);
            string carInfo = row.Cells["Marka"].Value + " " + row.Cells["Model"].Value + " (" + row.Cells["NrRejestracyjny"].Value + ")";

            DialogResult confirm = MessageBox.Show("Czy na pewno chcesz bezpowrotnie usunąć pojazd " + carInfo + "?", 
                                                   "Potwierdzenie usunięcia", 
                                                   MessageBoxButtons.YesNo, 
                                                   MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DbHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Samochody WHERE Id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", carId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Pojazd został pomyślnie usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WczytajSamochody();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas usuwania pojazdu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_exportCsv_Click(object sender, EventArgs e)
        {
            if (dataGridView_cars.Rows.Count == 0)
            {
                MessageBox.Show("Brak danych do wyeksportowania.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Pliki CSV (*.csv)|*.csv";
                sfd.FileName = "Pojazdy_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
                sfd.Title = "Eksportuj listę pojazdów do CSV";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();

                        // Headers
                        List<string> headers = new List<string>();
                        foreach (DataGridViewColumn col in dataGridView_cars.Columns)
                        {
                            if (col.Visible)
                                headers.Add("\"" + col.HeaderText.Replace("\"", "\"\"") + "\"");
                        }
                        sb.AppendLine(string.Join(";", headers));

                        // Rows
                        foreach (DataGridViewRow row in dataGridView_cars.Rows)
                        {
                            List<string> cells = new List<string>();
                            foreach (DataGridViewColumn col in dataGridView_cars.Columns)
                            {
                                if (col.Visible)
                                {
                                    object val = row.Cells[col.Index].Value;
                                    string text = val != null ? val.ToString().Replace("\"", "\"\"") : string.Empty;
                                    cells.Add("\"" + text + "\"");
                                }
                            }
                            sb.AppendLine(string.Join(";", cells));
                        }

                        // Write with UTF-8 BOM so Excel opens Polish characters seamlessly
                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                        MessageBox.Show("Pomyślnie wyeksportowano dane do pliku:\n" + sfd.FileName, "Eksport zakończony", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd zapisu pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView_cars_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_cars.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Gotowy do odbioru")
                {
                    e.CellStyle.BackColor = Color.FromArgb(6, 78, 59); // Deep Emerald
                    e.CellStyle.ForeColor = Color.FromArgb(167, 243, 208);
                    e.CellStyle.Font = new Font(dataGridView_cars.Font, FontStyle.Bold);
                }
                else if (status == "W trakcie naprawy" || status == "Diagnostyka" || status == "Oczekiwanie na części")
                {
                    e.CellStyle.BackColor = Color.FromArgb(120, 53, 15); // Deep Amber
                    e.CellStyle.ForeColor = Color.FromArgb(254, 215, 170);
                    e.CellStyle.Font = new Font(dataGridView_cars.Font, FontStyle.Bold);
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
    }
}
