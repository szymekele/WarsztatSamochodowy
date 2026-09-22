using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarsztatSamochodowy
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
            AppBranding.ApplyWindowIcon(this);
            this.EnableDoubleBuffering();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            this.Hide();
            loginForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_firstname.Text) || 
                string.IsNullOrWhiteSpace(textBox_surname.Text) || 
                string.IsNullOrWhiteSpace(textBox_login.Text) || 
                string.IsNullOrWhiteSpace(textBox_password.Text))
            {
                MessageBox.Show("Uzupełnij pola oznaczone *. Są to pola obowiązkowe.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox_firstname.TextLength < 3 || textBox_firstname.TextLength > 15)
            {
                MessageBox.Show("Imię musi liczyć min. 3 znaki i maks. 15 znaków.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox_surname.TextLength < 2 || textBox_surname.TextLength > 20)
            {
                MessageBox.Show("Nazwisko musi liczyć min. 2 znaki i maks. 20 znaków.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox_login.TextLength < 3)
            {
                MessageBox.Show("Login musi liczyć min. 3 znaki!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox_password.TextLength < 5)
            {
                MessageBox.Show("Hasło musi liczyć min. 5 znaków!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Uzytkownicy WHERE Login = @login";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", textBox_login.Text.Trim());

                    int userExists = (int)cmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("Użytkownik o takim loginie już istnieje!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query2 = @"INSERT INTO Uzytkownicy (Imie, Nazwisko, Email, Telefon, Login, PasswordHash, Adres) VALUES (@imie, @nazwisko, @email, @telefon, @login, @haslo, @adres)";

                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@imie", textBox_firstname.Text.Trim());
                    cmd2.Parameters.AddWithValue("@nazwisko", textBox_surname.Text.Trim());
                    cmd2.Parameters.AddWithValue("@email", maskedTextBox_email.Text.Trim());
                    cmd2.Parameters.AddWithValue("@telefon", maskedTextBox_phone.Text.Trim());
                    cmd2.Parameters.AddWithValue("@login", textBox_login.Text.Trim());
                    cmd2.Parameters.AddWithValue("@haslo", PasswordHelper.HashPassword(textBox_password.Text));
                    cmd2.Parameters.AddWithValue("@adres", textBox_address.Text.Trim());

                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Użytkownik został pomyślnie utworzony.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loginForm login = new loginForm();
                    this.Hide();
                    login.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z bazą danych! " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void maskedTextBox_email_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
