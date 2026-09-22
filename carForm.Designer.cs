namespace WarsztatSamochodowy
{
    partial class carForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_uzytkownik = new System.Windows.Forms.Label();
            this.button_home = new System.Windows.Forms.Button();
            this.button_dodajsamochod = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.panel_toolbar = new System.Windows.Forms.Panel();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.button_zmienStatus = new System.Windows.Forms.Button();
            this.button_usunSamochod = new System.Windows.Forms.Button();
            this.button_exportCsv = new System.Windows.Forms.Button();
            this.dataGridView_cars = new System.Windows.Forms.DataGridView();
            this.label_count = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel_toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cars)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.label_uzytkownik);
            this.panel_top.Controls.Add(this.button_home);
            this.panel_top.Controls.Add(this.button_dodajsamochod);
            this.panel_top.Controls.Add(this.button_logout);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(980, 70);
            this.panel_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "WarsztatDB";
            // 
            // label_uzytkownik
            // 
            this.label_uzytkownik.AutoSize = true;
            this.label_uzytkownik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_uzytkownik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label_uzytkownik.Location = new System.Drawing.Point(16, 43);
            this.label_uzytkownik.Name = "label_uzytkownik";
            this.label_uzytkownik.Size = new System.Drawing.Size(30, 17);
            this.label_uzytkownik.TabIndex = 13;
            this.label_uzytkownik.Text = "null";
            this.label_uzytkownik.Click += new System.EventHandler(this.label_uzytkownik_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(600, 18);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(100, 34);
            this.button_home.TabIndex = 29;
            this.button_home.Text = "Pulpit";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_dodajsamochod
            // 
            this.button_dodajsamochod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.button_dodajsamochod.FlatAppearance.BorderSize = 0;
            this.button_dodajsamochod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dodajsamochod.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodajsamochod.ForeColor = System.Drawing.Color.White;
            this.button_dodajsamochod.Location = new System.Drawing.Point(710, 18);
            this.button_dodajsamochod.Name = "button_dodajsamochod";
            this.button_dodajsamochod.Size = new System.Drawing.Size(140, 34);
            this.button_dodajsamochod.TabIndex = 31;
            this.button_dodajsamochod.Text = "+ Dodaj pojazd";
            this.button_dodajsamochod.UseVisualStyleBackColor = false;
            this.button_dodajsamochod.Click += new System.EventHandler(this.button_dodajsamochod_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(860, 18);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(100, 34);
            this.button_logout.TabIndex = 40;
            this.button_logout.Text = "Wyloguj";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // panel_toolbar
            // 
            this.panel_toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_toolbar.Controls.Add(this.label_search);
            this.panel_toolbar.Controls.Add(this.textBox_search);
            this.panel_toolbar.Controls.Add(this.label_status);
            this.panel_toolbar.Controls.Add(this.comboBox_status);
            this.panel_toolbar.Controls.Add(this.button_zmienStatus);
            this.panel_toolbar.Controls.Add(this.button_usunSamochod);
            this.panel_toolbar.Controls.Add(this.button_exportCsv);
            this.panel_toolbar.Location = new System.Drawing.Point(20, 85);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(940, 50);
            this.panel_toolbar.TabIndex = 1;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search.ForeColor = System.Drawing.Color.White;
            this.label_search.Location = new System.Drawing.Point(12, 16);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(46, 17);
            this.label_search.TabIndex = 0;
            this.label_search.Text = "Szukaj:";
            // 
            // textBox_search
            // 
            this.textBox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_search.ForeColor = System.Drawing.Color.White;
            this.textBox_search.Location = new System.Drawing.Point(62, 13);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(180, 25);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_status.ForeColor = System.Drawing.Color.White;
            this.label_status.Location = new System.Drawing.Point(255, 16);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(46, 17);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "Status:";
            // 
            // comboBox_status
            // 
            this.comboBox_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_status.ForeColor = System.Drawing.Color.White;
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Wszystkie",
            "Przyjęty",
            "W trakcie naprawy",
            "Gotowy do odbioru",
            "Wydany"});
            this.comboBox_status.Location = new System.Drawing.Point(305, 14);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(140, 23);
            this.comboBox_status.TabIndex = 3;
            this.comboBox_status.SelectedIndexChanged += new System.EventHandler(this.comboBox_status_SelectedIndexChanged);
            // 
            // button_zmienStatus
            // 
            this.button_zmienStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.button_zmienStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_zmienStatus.FlatAppearance.BorderSize = 0;
            this.button_zmienStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zmienStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zmienStatus.ForeColor = System.Drawing.Color.White;
            this.button_zmienStatus.Location = new System.Drawing.Point(470, 11);
            this.button_zmienStatus.Name = "button_zmienStatus";
            this.button_zmienStatus.Size = new System.Drawing.Size(145, 28);
            this.button_zmienStatus.TabIndex = 4;
            this.button_zmienStatus.Text = "Zmień status / koszt";
            this.button_zmienStatus.UseVisualStyleBackColor = false;
            this.button_zmienStatus.Click += new System.EventHandler(this.button_zmienStatus_Click);
            // 
            // button_usunSamochod
            // 
            this.button_usunSamochod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_usunSamochod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_usunSamochod.FlatAppearance.BorderSize = 0;
            this.button_usunSamochod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_usunSamochod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usunSamochod.ForeColor = System.Drawing.Color.White;
            this.button_usunSamochod.Location = new System.Drawing.Point(630, 11);
            this.button_usunSamochod.Name = "button_usunSamochod";
            this.button_usunSamochod.Size = new System.Drawing.Size(125, 28);
            this.button_usunSamochod.TabIndex = 5;
            this.button_usunSamochod.Text = "Usuń pojazd";
            this.button_usunSamochod.UseVisualStyleBackColor = false;
            this.button_usunSamochod.Click += new System.EventHandler(this.button_usunSamochod_Click);
            // 
            // button_exportCsv
            // 
            this.button_exportCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.button_exportCsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exportCsv.FlatAppearance.BorderSize = 0;
            this.button_exportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exportCsv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exportCsv.ForeColor = System.Drawing.Color.White;
            this.button_exportCsv.Location = new System.Drawing.Point(770, 11);
            this.button_exportCsv.Name = "button_exportCsv";
            this.button_exportCsv.Size = new System.Drawing.Size(130, 28);
            this.button_exportCsv.TabIndex = 6;
            this.button_exportCsv.Text = "Eksportuj CSV";
            this.button_exportCsv.UseVisualStyleBackColor = false;
            this.button_exportCsv.Click += new System.EventHandler(this.button_exportCsv_Click);
            // 
            // dataGridView_cars
            // 
            this.dataGridView_cars.AllowUserToAddRows = false;
            this.dataGridView_cars.AllowUserToDeleteRows = false;
            this.dataGridView_cars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_cars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dataGridView_cars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_cars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_cars.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_cars.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_cars.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.dataGridView_cars.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_cars.EnableHeadersVisualStyles = false;
            this.dataGridView_cars.Location = new System.Drawing.Point(20, 150);
            this.dataGridView_cars.MultiSelect = false;
            this.dataGridView_cars.Name = "dataGridView_cars";
            this.dataGridView_cars.ReadOnly = true;
            this.dataGridView_cars.RowHeadersVisible = false;
            this.dataGridView_cars.RowTemplate.Height = 32;
            this.dataGridView_cars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cars.Size = new System.Drawing.Size(940, 365);
            this.dataGridView_cars.TabIndex = 50;
            this.dataGridView_cars.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_cars_CellFormatting);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_count.Location = new System.Drawing.Point(22, 525);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(126, 15);
            this.label_count.TabIndex = 51;
            this.label_count.Text = "Znaleziono pojazdów: 0";
            // 
            // carForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(980, 555);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.dataGridView_cars);
            this.Controls.Add(this.panel_toolbar);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "carForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarsztatDB - Lista pojazdów";
            this.Load += new System.EventHandler(this.carForm_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_toolbar.ResumeLayout(false);
            this.panel_toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_uzytkownik;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_dodajsamochod;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel panel_toolbar;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Button button_zmienStatus;
        private System.Windows.Forms.Button button_usunSamochod;
        private System.Windows.Forms.Button button_exportCsv;
        private System.Windows.Forms.DataGridView dataGridView_cars;
        private System.Windows.Forms.Label label_count;
    }
}