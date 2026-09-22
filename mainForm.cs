using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WarsztatSamochodowy
{
    public partial class mainForm : Form
    {
        private UserSession session;

        public mainForm()
        {
            InitializeComponent();
            AppBranding.ApplyWindowIcon(this);
            this.EnableDoubleBuffering();
            dataGridView_recent.EnableDoubleBuffering();
        }

        public mainForm(UserSession session) : this()
        {
            this.session = session;
            if (session != null)
            {
                label_uzytkownik.Text = session.OpisRoli + " • " + session.PelnaNazwa;
            }
        }

        public mainForm(string imie, string nazwisko, string rola, string login)
            : this(new UserSession(imie, nazwisko, rola, login))
        {
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (session != null)
            {
                button_adminPanel.Visible = string.Equals(session.Rola, "Administrator", StringComparison.OrdinalIgnoreCase) ||
                                            string.Equals(session.Rola, "Admin", StringComparison.OrdinalIgnoreCase);
                button_repairs.Visible = session.CzyPracownikLubAdmin;

                label_statusBottom.Text = string.Format(
                    "Stan bazy danych: Połączono (LocalDB) • Rola: {0} ({1}) • Sesja aktywna • {2:yyyy-MM-dd HH:mm}",
                    session.Rola,
                    session.Login,
                    DateTime.Now
                );
            }

            WczytajDanePulpitu();
        }

        private void WczytajDanePulpitu()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    bool isAdmin = session != null && session.CzyPracownikLubAdmin;
                    int userId = session != null ? session.Id : -1;

                    // 1. Zliczanie statystyk
                    string countQuery = isAdmin
                        ? @"SELECT 
                                COUNT(*) AS Total,
                                SUM(CASE WHEN Status IN ('W trakcie naprawy', 'Diagnostyka', 'Oczekiwanie na części') THEN 1 ELSE 0 END) AS InProgress,
                                SUM(CASE WHEN Status = 'Gotowy do odbioru' THEN 1 ELSE 0 END) AS Ready,
                                ISNULL(SUM(KosztNaprawy), 0) AS TotalCost
                            FROM Samochody;"
                        : @"SELECT 
                                COUNT(*) AS Total,
                                SUM(CASE WHEN Status IN ('W trakcie naprawy', 'Diagnostyka', 'Oczekiwanie na części') THEN 1 ELSE 0 END) AS InProgress,
                                SUM(CASE WHEN Status = 'Gotowy do odbioru' THEN 1 ELSE 0 END) AS Ready,
                                ISNULL(SUM(KosztNaprawy), 0) AS TotalCost
                            FROM Samochody 
                            WHERE KlientId = @uid;";

                    using (SqlCommand cmd = new SqlCommand(countQuery, conn))
                    {
                        if (!isAdmin)
                        {
                            cmd.Parameters.AddWithValue("@uid", userId);
                        }

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int total = reader["Total"] != DBNull.Value ? Convert.ToInt32(reader["Total"]) : 0;
                                int inProgress = reader["InProgress"] != DBNull.Value ? Convert.ToInt32(reader["InProgress"]) : 0;
                                int ready = reader["Ready"] != DBNull.Value ? Convert.ToInt32(reader["Ready"]) : 0;
                                decimal totalCost = reader["TotalCost"] != DBNull.Value ? Convert.ToDecimal(reader["TotalCost"]) : 0m;

                                label_c1_val.Text = total.ToString();
                                label_c2_val.Text = inProgress.ToString();
                                label_c3_val.Text = ready.ToString();
                                label_c4_val.Text = string.Format("{0:N2} zł", totalCost);
                            }
                        }
                    }

                    // 2. Ostatnie pojazdy
                    string recentQuery = isAdmin
                        ? @"SELECT TOP 8 s.Id, s.Marka, s.Model, s.NrRejestracyjny, s.VIN, s.Status, 
                                         ISNULL(s.KosztNaprawy, 0) AS [Koszt (zł)], 
                                         ISNULL(u.Imie + ' ' + u.Nazwisko, 'Brak') AS Wlasciciel,
                                         s.DataPrzyjecia AS [Data przyjęcia]
                            FROM Samochody s
                            LEFT JOIN Uzytkownicy u ON s.KlientId = u.Id
                            ORDER BY s.Id DESC;"
                        : @"SELECT TOP 8 Id, Marka, Model, NrRejestracyjny, VIN, Status, 
                                         ISNULL(KosztNaprawy, 0) AS [Koszt (zł)], 
                                         DataPrzyjecia AS [Data przyjęcia]
                            FROM Samochody
                            WHERE KlientId = @uid
                            ORDER BY Id DESC;";

                    using (SqlCommand cmdRecent = new SqlCommand(recentQuery, conn))
                    {
                        if (!isAdmin)
                        {
                            cmdRecent.Parameters.AddWithValue("@uid", userId);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmdRecent);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView_recent.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się załadować podsumowania pulpitu: " + ex.Message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_recent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_recent.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Gotowy do odbioru")
                {
                    e.CellStyle.BackColor = Color.FromArgb(6, 78, 59); // Deep Emerald
                    e.CellStyle.ForeColor = Color.FromArgb(167, 243, 208);
                    e.CellStyle.Font = new Font(dataGridView_recent.Font, FontStyle.Bold);
                }
                else if (status == "W trakcie naprawy" || status == "Diagnostyka" || status == "Oczekiwanie na części")
                {
                    e.CellStyle.BackColor = Color.FromArgb(120, 53, 15); // Deep Amber
                    e.CellStyle.ForeColor = Color.FromArgb(254, 215, 170);
                    e.CellStyle.Font = new Font(dataGridView_recent.Font, FontStyle.Bold);
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

        private void label_kto_Click(object sender, EventArgs e)
        {
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                loginForm login = new loginForm();
                this.Hide();
                login.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carForm car = new carForm(session);
            this.Hide();
            car.Show();
        }

        private void button_repairs_Click(object sender, EventArgs e)
        {
            repairsManagementForm repairs = new repairsManagementForm(session);
            this.Hide();
            repairs.Show();
        }

        private void button_adminPanel_Click(object sender, EventArgs e)
        {
            adminUsersForm admin = new adminUsersForm(session);
            this.Hide();
            admin.Show();
        }

        private void button_addCar_Click(object sender, EventArgs e)
        {
            addCarForm add = new addCarForm(session);
            this.Hide();
            add.Show();
        }

        private void button_dane_Click(object sender, EventArgs e)
        {
            userDataForm user = new userDataForm(session);
            this.Hide();
            user.Show();
        }
    }
}
