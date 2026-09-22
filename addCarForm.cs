using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WarsztatSamochodowy
{
    public partial class addCarForm : Form
    {
        private UserSession session;

        public addCarForm()
        {
            InitializeComponent();
            AppBranding.ApplyWindowIcon(this);
            this.EnableDoubleBuffering();
        }

        public addCarForm(UserSession session) : this()
        {
            this.session = session;
            if (session != null)
            {
                label_uzytkownik.Text = session.OpisRoli;
            }
        }

        public addCarForm(string imie, string nazwisko, string rola, string login)
            : this(new UserSession(imie, nazwisko, rola, login))
        {
        }

        private void addCarForm_Load(object sender, EventArgs e)
        {
        }

        private void button_dodajsamochod_Click(object sender, EventArgs e)
        {
            string marka = textBox_marka.Text.Trim();
            string model = textBox_model.Text.Trim();
            string nrRej = textBox_numerrejestracyjny.Text.Trim().ToUpper();
            string rokProd = maskedTextBox_rokprodukcji.Text.Trim();
            string vin = textBox_vin.Text.Trim().ToUpper();
            string opis = textBox_opisuszkodzen.Text.Trim();
            string uwagi = textBox_uwagi.Text.Trim();

            if (string.IsNullOrWhiteSpace(marka) || string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Uzupełnij markę i model pojazdu. Są to pola wymagane.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nrRej) || nrRej.Length < 4)
            {
                MessageBox.Show("Numer rejestracyjny musi liczyć co najmniej 4 znaki.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(vin) && vin.Length != 17)
            {
                MessageBox.Show("Numer VIN, jeśli podany, powinien liczyć dokładnie 17 znaków.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    int clientId = session != null && session.Id > 0 ? session.Id : -1;

                    if (clientId <= 0 && session != null)
                    {
                        SqlCommand cmdUser = new SqlCommand("SELECT Id FROM Uzytkownicy WHERE Login = @login", conn);
                        cmdUser.Parameters.AddWithValue("@login", session.Login);
                        object res = cmdUser.ExecuteScalar();
                        if (res != null)
                        {
                            clientId = Convert.ToInt32(res);
                            session.Id = clientId;
                        }
                    }

                    string query = @"INSERT INTO Samochody 
                                     (KlientId, Marka, Model, RokProdukcji, NrRejestracyjny, VIN, OpisUszkodzen, Uwagi, DataPrzyjecia, Status, KosztNaprawy) 
                                     VALUES 
                                     (@klientid, @marka, @model, @rokprodukcji, @nrrejestracyjny, @vin, @opisuszkodzen, @uwagi, GETDATE(), 'Przyjęty', 0.00)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@klientid", clientId > 0 ? (object)clientId : DBNull.Value);
                        cmd.Parameters.AddWithValue("@marka", marka);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@rokprodukcji", string.IsNullOrWhiteSpace(rokProd) ? (object)DBNull.Value : rokProd);
                        cmd.Parameters.AddWithValue("@nrrejestracyjny", nrRej);
                        cmd.Parameters.AddWithValue("@vin", string.IsNullOrWhiteSpace(vin) ? (object)DBNull.Value : vin);
                        cmd.Parameters.AddWithValue("@opisuszkodzen", string.IsNullOrWhiteSpace(opis) ? (object)DBNull.Value : opis);
                        cmd.Parameters.AddWithValue("@uwagi", string.IsNullOrWhiteSpace(uwagi) ? (object)DBNull.Value : uwagi);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Pojazd został pomyślnie zarejestrowany w systemie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carForm car = new carForm(session);
                    this.Hide();
                    car.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z bazą danych podczas dodawania pojazdu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label_cofnij_Click(object sender, EventArgs e)
        {
            carForm car = new carForm(session);
            this.Hide();
            car.Show();
        }
    }
}
