namespace WarsztatSamochodowy
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_uzytkownik = new System.Windows.Forms.Label();
            this.label_statusBottom = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_cars = new System.Windows.Forms.Button();
            this.button_repairs = new System.Windows.Forms.Button();
            this.button_adminPanel = new System.Windows.Forms.Button();
            this.button_dane = new System.Windows.Forms.Button();
            this.button_addCar = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_nav = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_card1 = new System.Windows.Forms.Panel();
            this.label_c1_val = new System.Windows.Forms.Label();
            this.label_c1_title = new System.Windows.Forms.Label();
            this.panel_card2 = new System.Windows.Forms.Panel();
            this.label_c2_val = new System.Windows.Forms.Label();
            this.label_c2_title = new System.Windows.Forms.Label();
            this.panel_card3 = new System.Windows.Forms.Panel();
            this.label_c3_val = new System.Windows.Forms.Label();
            this.label_c3_title = new System.Windows.Forms.Label();
            this.panel_card4 = new System.Windows.Forms.Panel();
            this.label_c4_val = new System.Windows.Forms.Label();
            this.label_c4_title = new System.Windows.Forms.Label();
            this.label_recentTitle = new System.Windows.Forms.Label();
            this.dataGridView_recent = new System.Windows.Forms.DataGridView();
            this.panel_statusStrip = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.flowLayoutPanel_nav.SuspendLayout();
            this.panel_card1.SuspendLayout();
            this.panel_card2.SuspendLayout();
            this.panel_card3.SuspendLayout();
            this.panel_card4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recent)).BeginInit();
            this.panel_statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.label_uzytkownik);
            this.panel_top.Controls.Add(this.flowLayoutPanel_nav);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1040, 72);
            this.panel_top.TabIndex = 0;
            // 
            // flowLayoutPanel_nav
            // 
            this.flowLayoutPanel_nav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_nav.AutoSize = true;
            this.flowLayoutPanel_nav.Controls.Add(this.button_cars);
            this.flowLayoutPanel_nav.Controls.Add(this.button_repairs);
            this.flowLayoutPanel_nav.Controls.Add(this.button_adminPanel);
            this.flowLayoutPanel_nav.Controls.Add(this.button_addCar);
            this.flowLayoutPanel_nav.Controls.Add(this.button_dane);
            this.flowLayoutPanel_nav.Controls.Add(this.button_logout);
            this.flowLayoutPanel_nav.Location = new System.Drawing.Point(320, 16);
            this.flowLayoutPanel_nav.Name = "flowLayoutPanel_nav";
            this.flowLayoutPanel_nav.Size = new System.Drawing.Size(705, 42);
            this.flowLayoutPanel_nav.TabIndex = 1;
            this.flowLayoutPanel_nav.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "WarsztatDB";
            // 
            // label_uzytkownik
            // 
            this.label_uzytkownik.AutoSize = true;
            this.label_uzytkownik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_uzytkownik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label_uzytkownik.Location = new System.Drawing.Point(18, 45);
            this.label_uzytkownik.Name = "label_uzytkownik";
            this.label_uzytkownik.Size = new System.Drawing.Size(30, 17);
            this.label_uzytkownik.TabIndex = 12;
            this.label_uzytkownik.Text = "null";
            this.label_uzytkownik.Click += new System.EventHandler(this.label_kto_Click);
            // 
            // button_cars
            // 
            this.button_cars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.button_cars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cars.FlatAppearance.BorderSize = 0;
            this.button_cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cars.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cars.ForeColor = System.Drawing.Color.White;
            this.button_cars.Location = new System.Drawing.Point(3, 2);
            this.button_cars.Margin = new System.Windows.Forms.Padding(3, 2, 4, 2);
            this.button_cars.Name = "button_cars";
            this.button_cars.Size = new System.Drawing.Size(95, 34);
            this.button_cars.TabIndex = 27;
            this.button_cars.Text = "Pojazdy";
            this.button_cars.UseVisualStyleBackColor = false;
            this.button_cars.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_repairs
            // 
            this.button_repairs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.button_repairs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_repairs.FlatAppearance.BorderSize = 0;
            this.button_repairs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_repairs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_repairs.ForeColor = System.Drawing.Color.White;
            this.button_repairs.Location = new System.Drawing.Point(105, 2);
            this.button_repairs.Margin = new System.Windows.Forms.Padding(3, 2, 4, 2);
            this.button_repairs.Name = "button_repairs";
            this.button_repairs.Size = new System.Drawing.Size(115, 34);
            this.button_repairs.TabIndex = 28;
            this.button_repairs.Text = "Naprawy";
            this.button_repairs.UseVisualStyleBackColor = false;
            this.button_repairs.Click += new System.EventHandler(this.button_repairs_Click);
            // 
            // button_adminPanel
            // 
            this.button_adminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.button_adminPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_adminPanel.FlatAppearance.BorderSize = 0;
            this.button_adminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_adminPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_adminPanel.ForeColor = System.Drawing.Color.White;
            this.button_adminPanel.Location = new System.Drawing.Point(227, 2);
            this.button_adminPanel.Margin = new System.Windows.Forms.Padding(3, 2, 4, 2);
            this.button_adminPanel.Name = "button_adminPanel";
            this.button_adminPanel.Size = new System.Drawing.Size(110, 34);
            this.button_adminPanel.TabIndex = 29;
            this.button_adminPanel.Text = "Panel Admina";
            this.button_adminPanel.UseVisualStyleBackColor = false;
            this.button_adminPanel.Visible = false;
            this.button_adminPanel.Click += new System.EventHandler(this.button_adminPanel_Click);
            // 
            // button_addCar
            // 
            this.button_addCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.button_addCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addCar.FlatAppearance.BorderSize = 0;
            this.button_addCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addCar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_addCar.ForeColor = System.Drawing.Color.White;
            this.button_addCar.Location = new System.Drawing.Point(344, 2);
            this.button_addCar.Margin = new System.Windows.Forms.Padding(3, 2, 4, 2);
            this.button_addCar.Name = "button_addCar";
            this.button_addCar.Size = new System.Drawing.Size(110, 34);
            this.button_addCar.TabIndex = 30;
            this.button_addCar.Text = "+ Nowe auto";
            this.button_addCar.UseVisualStyleBackColor = false;
            this.button_addCar.Click += new System.EventHandler(this.button_addCar_Click);
            // 
            // button_dane
            // 
            this.button_dane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.button_dane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dane.FlatAppearance.BorderSize = 0;
            this.button_dane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dane.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dane.ForeColor = System.Drawing.Color.White;
            this.button_dane.Location = new System.Drawing.Point(461, 2);
            this.button_dane.Margin = new System.Windows.Forms.Padding(3, 2, 4, 2);
            this.button_dane.Name = "button_dane";
            this.button_dane.Size = new System.Drawing.Size(95, 34);
            this.button_dane.TabIndex = 31;
            this.button_dane.Text = "Mój profil";
            this.button_dane.UseVisualStyleBackColor = false;
            this.button_dane.Click += new System.EventHandler(this.button_dane_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(563, 2);
            this.button_logout.Margin = new System.Windows.Forms.Padding(3, 2, 4, 2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(95, 34);
            this.button_logout.TabIndex = 32;
            this.button_logout.Text = "Wyloguj";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // panel_card1
            // 
            this.panel_card1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_card1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_card1.Controls.Add(this.label_c1_val);
            this.panel_card1.Controls.Add(this.label_c1_title);
            this.panel_card1.Location = new System.Drawing.Point(20, 90);
            this.panel_card1.Name = "panel_card1";
            this.panel_card1.Size = new System.Drawing.Size(235, 85);
            this.panel_card1.TabIndex = 36;
            // 
            // label_c1_val
            // 
            this.label_c1_val.AutoSize = true;
            this.label_c1_val.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_c1_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label_c1_val.Location = new System.Drawing.Point(12, 35);
            this.label_c1_val.Name = "label_c1_val";
            this.label_c1_val.Size = new System.Drawing.Size(35, 41);
            this.label_c1_val.TabIndex = 1;
            this.label_c1_val.Text = "0";
            // 
            // label_c1_title
            // 
            this.label_c1_title.AutoSize = true;
            this.label_c1_title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_c1_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_c1_title.Location = new System.Drawing.Point(14, 12);
            this.label_c1_title.Name = "label_c1_title";
            this.label_c1_title.Size = new System.Drawing.Size(117, 17);
            this.label_c1_title.TabIndex = 0;
            this.label_c1_title.Text = "Wszystkie pojazdy";
            // 
            // panel_card2
            // 
            this.panel_card2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_card2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_card2.Controls.Add(this.label_c2_val);
            this.panel_card2.Controls.Add(this.label_c2_title);
            this.panel_card2.Location = new System.Drawing.Point(275, 90);
            this.panel_card2.Name = "panel_card2";
            this.panel_card2.Size = new System.Drawing.Size(235, 85);
            this.panel_card2.TabIndex = 37;
            // 
            // label_c2_val
            // 
            this.label_c2_val.AutoSize = true;
            this.label_c2_val.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_c2_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.label_c2_val.Location = new System.Drawing.Point(12, 35);
            this.label_c2_val.Name = "label_c2_val";
            this.label_c2_val.Size = new System.Drawing.Size(35, 41);
            this.label_c2_val.TabIndex = 1;
            this.label_c2_val.Text = "0";
            // 
            // label_c2_title
            // 
            this.label_c2_title.AutoSize = true;
            this.label_c2_title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_c2_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_c2_title.Location = new System.Drawing.Point(14, 12);
            this.label_c2_title.Name = "label_c2_title";
            this.label_c2_title.Size = new System.Drawing.Size(76, 17);
            this.label_c2_title.TabIndex = 0;
            this.label_c2_title.Text = "W naprawie";
            // 
            // panel_card3
            // 
            this.panel_card3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_card3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_card3.Controls.Add(this.label_c3_val);
            this.panel_card3.Controls.Add(this.label_c3_title);
            this.panel_card3.Location = new System.Drawing.Point(530, 90);
            this.panel_card3.Name = "panel_card3";
            this.panel_card3.Size = new System.Drawing.Size(235, 85);
            this.panel_card3.TabIndex = 38;
            // 
            // label_c3_val
            // 
            this.label_c3_val.AutoSize = true;
            this.label_c3_val.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_c3_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.label_c3_val.Location = new System.Drawing.Point(12, 35);
            this.label_c3_val.Name = "label_c3_val";
            this.label_c3_val.Size = new System.Drawing.Size(35, 41);
            this.label_c3_val.TabIndex = 1;
            this.label_c3_val.Text = "0";
            // 
            // label_c3_title
            // 
            this.label_c3_title.AutoSize = true;
            this.label_c3_title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_c3_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_c3_title.Location = new System.Drawing.Point(14, 12);
            this.label_c3_title.Name = "label_c3_title";
            this.label_c3_title.Size = new System.Drawing.Size(124, 17);
            this.label_c3_title.TabIndex = 0;
            this.label_c3_title.Text = "Gotowe do odbioru";
            // 
            // panel_card4
            // 
            this.panel_card4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_card4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_card4.Controls.Add(this.label_c4_val);
            this.panel_card4.Controls.Add(this.label_c4_title);
            this.panel_card4.Location = new System.Drawing.Point(785, 90);
            this.panel_card4.Name = "panel_card4";
            this.panel_card4.Size = new System.Drawing.Size(235, 85);
            this.panel_card4.TabIndex = 39;
            // 
            // label_c4_val
            // 
            this.label_c4_val.AutoSize = true;
            this.label_c4_val.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_c4_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.label_c4_val.Location = new System.Drawing.Point(12, 38);
            this.label_c4_val.Name = "label_c4_val";
            this.label_c4_val.Size = new System.Drawing.Size(89, 32);
            this.label_c4_val.TabIndex = 1;
            this.label_c4_val.Text = "0,00 zł";
            // 
            // label_c4_title
            // 
            this.label_c4_title.AutoSize = true;
            this.label_c4_title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_c4_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_c4_title.Location = new System.Drawing.Point(14, 12);
            this.label_c4_title.Name = "label_c4_title";
            this.label_c4_title.Size = new System.Drawing.Size(89, 17);
            this.label_c4_title.TabIndex = 0;
            this.label_c4_title.Text = "Suma napraw";
            // 
            // label_recentTitle
            // 
            this.label_recentTitle.AutoSize = true;
            this.label_recentTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_recentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.label_recentTitle.Location = new System.Drawing.Point(16, 195);
            this.label_recentTitle.Name = "label_recentTitle";
            this.label_recentTitle.Size = new System.Drawing.Size(229, 25);
            this.label_recentTitle.TabIndex = 40;
            this.label_recentTitle.Text = "Ostatnio przyjęte pojazdy";
            // 
            // dataGridView_recent
            // 
            this.dataGridView_recent.AllowUserToAddRows = false;
            this.dataGridView_recent.AllowUserToDeleteRows = false;
            this.dataGridView_recent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_recent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dataGridView_recent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_recent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_recent.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_recent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_recent.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.dataGridView_recent.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_recent.EnableHeadersVisualStyles = false;
            this.dataGridView_recent.Location = new System.Drawing.Point(20, 230);
            this.dataGridView_recent.MultiSelect = false;
            this.dataGridView_recent.Name = "dataGridView_recent";
            this.dataGridView_recent.ReadOnly = true;
            this.dataGridView_recent.RowHeadersVisible = false;
            this.dataGridView_recent.RowTemplate.Height = 32;
            this.dataGridView_recent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_recent.Size = new System.Drawing.Size(1000, 250);
            this.dataGridView_recent.TabIndex = 41;
            this.dataGridView_recent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_recent_CellFormatting);
            // 
            // panel_statusStrip
            // 
            this.panel_statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_statusStrip.Controls.Add(this.label_statusBottom);
            this.panel_statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_statusStrip.Location = new System.Drawing.Point(0, 495);
            this.panel_statusStrip.Name = "panel_statusStrip";
            this.panel_statusStrip.Size = new System.Drawing.Size(1040, 30);
            this.panel_statusStrip.TabIndex = 42;
            // 
            // label_statusBottom
            // 
            this.label_statusBottom.AutoSize = true;
            this.label_statusBottom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_statusBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_statusBottom.Location = new System.Drawing.Point(12, 8);
            this.label_statusBottom.Name = "label_statusBottom";
            this.label_statusBottom.Size = new System.Drawing.Size(342, 13);
            this.label_statusBottom.TabIndex = 13;
            this.label_statusBottom.Text = "Stan bazy danych: Połączono (LocalDB) • System WarsztatDB aktywny";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1040, 525);
            this.Controls.Add(this.panel_statusStrip);
            this.Controls.Add(this.dataGridView_recent);
            this.Controls.Add(this.label_recentTitle);
            this.Controls.Add(this.panel_card4);
            this.Controls.Add(this.panel_card3);
            this.Controls.Add(this.panel_card2);
            this.Controls.Add(this.panel_card1);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarsztatDB - Pulpit główny";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.flowLayoutPanel_nav.ResumeLayout(false);
            this.flowLayoutPanel_nav.PerformLayout();
            this.panel_card1.ResumeLayout(false);
            this.panel_card1.PerformLayout();
            this.panel_card2.ResumeLayout(false);
            this.panel_card2.PerformLayout();
            this.panel_card3.ResumeLayout(false);
            this.panel_card3.PerformLayout();
            this.panel_card4.ResumeLayout(false);
            this.panel_card4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recent)).EndInit();
            this.panel_statusStrip.ResumeLayout(false);
            this.panel_statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_nav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_uzytkownik;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_cars;
        private System.Windows.Forms.Button button_repairs;
        private System.Windows.Forms.Button button_adminPanel;
        private System.Windows.Forms.Button button_addCar;
        private System.Windows.Forms.Button button_dane;
        private System.Windows.Forms.Panel panel_card1;
        private System.Windows.Forms.Label label_c1_val;
        private System.Windows.Forms.Label label_c1_title;
        private System.Windows.Forms.Panel panel_card2;
        private System.Windows.Forms.Label label_c2_val;
        private System.Windows.Forms.Label label_c2_title;
        private System.Windows.Forms.Panel panel_card3;
        private System.Windows.Forms.Label label_c3_val;
        private System.Windows.Forms.Label label_c3_title;
        private System.Windows.Forms.Panel panel_card4;
        private System.Windows.Forms.Label label_c4_val;
        private System.Windows.Forms.Label label_c4_title;
        private System.Windows.Forms.Label label_recentTitle;
        private System.Windows.Forms.DataGridView dataGridView_recent;
        private System.Windows.Forms.Panel panel_statusStrip;
        private System.Windows.Forms.Label label_statusBottom;
    }
}