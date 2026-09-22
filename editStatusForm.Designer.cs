namespace WarsztatSamochodowy
{
    partial class editStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_header = new System.Windows.Forms.Label();
            this.label_carInfo = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label_koszt = new System.Windows.Forms.Label();
            this.textBox_koszt = new System.Windows.Forms.TextBox();
            this.label_uwagi = new System.Windows.Forms.Label();
            this.textBox_uwagi = new System.Windows.Forms.TextBox();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label_header.Location = new System.Drawing.Point(24, 20);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(222, 25);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Aktualizacja stanu auta";
            // 
            // label_carInfo
            // 
            this.label_carInfo.AutoSize = true;
            this.label_carInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label_carInfo.Location = new System.Drawing.Point(26, 55);
            this.label_carInfo.Name = "label_carInfo";
            this.label_carInfo.Size = new System.Drawing.Size(126, 17);
            this.label_carInfo.TabIndex = 1;
            this.label_carInfo.Text = "Pojazd: Marka Model";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_status.ForeColor = System.Drawing.Color.White;
            this.label_status.Location = new System.Drawing.Point(26, 95);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(95, 17);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "Status naprawy:";
            // 
            // comboBox_status
            // 
            this.comboBox_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_status.ForeColor = System.Drawing.Color.White;
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Przyjęty",
            "W trakcie naprawy",
            "Gotowy do odbioru",
            "Wydany"});
            this.comboBox_status.Location = new System.Drawing.Point(29, 120);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(340, 25);
            this.comboBox_status.TabIndex = 3;
            // 
            // label_koszt
            // 
            this.label_koszt.AutoSize = true;
            this.label_koszt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_koszt.ForeColor = System.Drawing.Color.White;
            this.label_koszt.Location = new System.Drawing.Point(26, 160);
            this.label_koszt.Name = "label_koszt";
            this.label_koszt.Size = new System.Drawing.Size(127, 17);
            this.label_koszt.TabIndex = 4;
            this.label_koszt.Text = "Koszt naprawy (PLN):";
            // 
            // textBox_koszt
            // 
            this.textBox_koszt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.textBox_koszt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_koszt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_koszt.ForeColor = System.Drawing.Color.White;
            this.textBox_koszt.Location = new System.Drawing.Point(29, 185);
            this.textBox_koszt.Name = "textBox_koszt";
            this.textBox_koszt.Size = new System.Drawing.Size(340, 25);
            this.textBox_koszt.TabIndex = 5;
            // 
            // label_uwagi
            // 
            this.label_uwagi.AutoSize = true;
            this.label_uwagi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_uwagi.ForeColor = System.Drawing.Color.White;
            this.label_uwagi.Location = new System.Drawing.Point(26, 225);
            this.label_uwagi.Name = "label_uwagi";
            this.label_uwagi.Size = new System.Drawing.Size(46, 17);
            this.label_uwagi.TabIndex = 6;
            this.label_uwagi.Text = "Uwagi:";
            // 
            // textBox_uwagi
            // 
            this.textBox_uwagi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.textBox_uwagi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_uwagi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_uwagi.ForeColor = System.Drawing.Color.White;
            this.textBox_uwagi.Location = new System.Drawing.Point(29, 250);
            this.textBox_uwagi.Multiline = true;
            this.textBox_uwagi.Name = "textBox_uwagi";
            this.textBox_uwagi.Size = new System.Drawing.Size(340, 65);
            this.textBox_uwagi.TabIndex = 7;
            // 
            // button_zapisz
            // 
            this.button_zapisz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.button_zapisz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_zapisz.FlatAppearance.BorderSize = 0;
            this.button_zapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zapisz.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zapisz.ForeColor = System.Drawing.Color.White;
            this.button_zapisz.Location = new System.Drawing.Point(150, 335);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(110, 32);
            this.button_zapisz.TabIndex = 8;
            this.button_zapisz.Text = "Zapisz";
            this.button_zapisz.UseVisualStyleBackColor = false;
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);
            // 
            // button_anuluj
            // 
            this.button_anuluj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.button_anuluj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_anuluj.FlatAppearance.BorderSize = 0;
            this.button_anuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anuluj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_anuluj.ForeColor = System.Drawing.Color.White;
            this.button_anuluj.Location = new System.Drawing.Point(270, 335);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(100, 32);
            this.button_anuluj.TabIndex = 9;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = false;
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);
            // 
            // editStatusForm
            // 
            this.AcceptButton = this.button_zapisz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.CancelButton = this.button_anuluj;
            this.ClientSize = new System.Drawing.Size(400, 390);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.button_zapisz);
            this.Controls.Add(this.textBox_uwagi);
            this.Controls.Add(this.label_uwagi);
            this.Controls.Add(this.textBox_koszt);
            this.Controls.Add(this.label_koszt);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_carInfo);
            this.Controls.Add(this.label_header);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WarsztatDB - Edycja stanu pojazdu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label_carInfo;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label_koszt;
        private System.Windows.Forms.TextBox textBox_koszt;
        private System.Windows.Forms.Label label_uwagi;
        private System.Windows.Forms.TextBox textBox_uwagi;
        private System.Windows.Forms.Button button_zapisz;
        private System.Windows.Forms.Button button_anuluj;
    }
}
