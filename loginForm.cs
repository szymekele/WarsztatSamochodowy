using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WarsztatSamochodowy
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            AppBranding.ApplyWindowIcon(this);
            this.EnableDoubleBuffering();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            registerForm register = new registerForm();
            this.Hide();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string login = (textBox_login.Text ?? string.Empty).Trim();
            string password = textBox_password.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Uzupełnij login i hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sprawdzenie blokady Brute-Force (Lockout)
            int remainingSeconds;
            if (SecurityHelper.IsAccountLocked(login, out remainingSeconds))
            {
                MessageBox.Show(
                    string.Format("Konto {0} zostało tymczasowo zablokowane z powodu zbyt wielu nieudanych prób logowania.\nSpróbuj ponownie za {1} s.", login, remainingSeconds),
                    "Blokada bezpieczeństwa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );
                return;
            }

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Id, Imie, Nazwisko, Rola, Login, PasswordHash FROM Uzytkownicy WHERE Login = @login";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader["PasswordHash"].ToString();

                                if (PasswordHelper.VerifyPassword(password, storedPassword))
                                {
                                    // Pomyślne uwierzytelnienie - zresetuj licznik nieudanych prób
                                    SecurityHelper.ResetFailedAttempts(login);

                                    int id = Convert.ToInt32(reader["Id"]);
                                    string imie = reader["Imie"].ToString();
                                    string nazwisko = reader["Nazwisko"].ToString();
                                    string rola = reader["Rola"].ToString();
                                    string userLogin = reader["Login"].ToString();

                                    UserSession session = new UserSession(imie, nazwisko, rola, login, id);

                                    mainForm main = new mainForm(session);
                                    this.Hide();
                                    main.Show();
                                    return;
                                }
                            }

                            // Nieudana próba logowania - naliczanie w SecurityHelper
                            int failedAttempts = SecurityHelper.RecordFailedAttempt(login);
                            if (failedAttempts >= SecurityHelper.MaxFailedAttempts)
                            {
                                MessageBox.Show(
                                    "Osiągnięto limit nieudanych prób logowania! Konto zostało zablokowane na 3 minuty.",
                                    "Blokada bezpieczeństwa",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop
                                );
                            }
                            else
                            {
                                int remaining = SecurityHelper.MaxFailedAttempts - failedAttempts;
                                MessageBox.Show(
                                    string.Format("Niepoprawny login lub hasło!\nPozostało prób: {0}", remaining),
                                    "Błąd uwierzytelniania",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z bazą danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
