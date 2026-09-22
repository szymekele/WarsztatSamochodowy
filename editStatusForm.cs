using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WarsztatSamochodowy
{
    public partial class editStatusForm : Form
    {
        private int carId;

        public editStatusForm()
        {
            InitializeComponent();
            AppBranding.ApplyWindowIcon(this);
            this.EnableDoubleBuffering();
        }

        public editStatusForm(int carId, string carInfo, string currentStatus, decimal currentCost, string currentNotes) : this()
        {
            this.carId = carId;
            label_carInfo.Text = "Pojazd: " + carInfo;

            if (comboBox_status.Items.Contains(currentStatus))
                comboBox_status.SelectedItem = currentStatus;
            else if (comboBox_status.Items.Count > 0)
                comboBox_status.SelectedIndex = 0;

            textBox_koszt.Text = currentCost.ToString("F2");
            textBox_uwagi.Text = currentNotes ?? string.Empty;
        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            string newStatus = comboBox_status.SelectedItem != null ? comboBox_status.SelectedItem.ToString() : "Przyjęty";
            decimal cost = 0;

            if (!string.IsNullOrWhiteSpace(textBox_koszt.Text))
            {
                string costText = textBox_koszt.Text.Replace(".", ",");
                if (!decimal.TryParse(costText, out cost) || cost < 0)
                {
                    MessageBox.Show("Podaj poprawny koszt naprawy (np. 350,00).", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string uwagi = textBox_uwagi.Text.Trim();

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Samochody 
                                     SET Status = @status, 
                                         KosztNaprawy = @koszt, 
                                         Uwagi = @uwagi,
                                         DataWydania = CASE WHEN @status = 'Wydany' THEN GETDATE() ELSE DataWydania END
                                     WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@koszt", cost);
                        cmd.Parameters.AddWithValue("@uwagi", (object)uwagi ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@id", carId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Stan pojazdu został zaktualizowany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
