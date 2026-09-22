namespace WarsztatSamochodowy
{
    partial class repairsManagementForm
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
            this.label_logo = new System.Windows.Forms.Label();
            this.label_userInfo = new System.Windows.Forms.Label();
            this.button_home = new System.Windows.Forms.Button();
            this.panel_toolbar = new System.Windows.Forms.Panel();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_etapFilter = new System.Windows.Forms.Label();
            this.comboBox_etapFilter = new System.Windows.Forms.ComboBox();
            this.label_mechanikFilter = new System.Windows.Forms.Label();
            this.comboBox_mechanikFilter = new System.Windows.Forms.ComboBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.dataGridView_repairs = new System.Windows.Forms.DataGridView();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.label_editHeader = new System.Windows.Forms.Label();
            this.label_carSelected = new System.Windows.Forms.Label();
            this.label_etap = new System.Windows.Forms.Label();
            this.comboBox_etap = new System.Windows.Forms.ComboBox();
            this.label_mechanik = new System.Windows.Forms.Label();
            this.comboBox_mechanik = new System.Windows.Forms.ComboBox();
            this.label_robocizna = new System.Windows.Forms.Label();
            this.textBox_robocizna = new System.Windows.Forms.TextBox();
            this.label_czesci = new System.Windows.Forms.Label();
            this.textBox_czesci = new System.Windows.Forms.TextBox();
            this.label_opis = new System.Windows.Forms.Label();
            this.textBox_opis = new System.Windows.Forms.TextBox();
            this.button_zapiszZlecenie = new System.Windows.Forms.Button();
            this.label_sumaKoszt = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel_toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_repairs)).BeginInit();
            this.panel_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_top.Controls.Add(this.label_logo);
            this.panel_top.Controls.Add(this.label_userInfo);
            this.panel_top.Controls.Add(this.button_home);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1080, 70);
            this.panel_top.TabIndex = 0;
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label_logo.Location = new System.Drawing.Point(12, 9);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(434, 32);
            this.label_logo.TabIndex = 0;
            this.label_logo.Text = "WarsztatDB - Zarządzanie Naprawami";
            // 
            // label_userInfo
            // 
            this.label_userInfo.AutoSize = true;
            this.label_userInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_userInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label_userInfo.Location = new System.Drawing.Point(16, 43);
            this.label_userInfo.Name = "label_userInfo";
            this.label_userInfo.Size = new System.Drawing.Size(262, 17);
            this.label_userInfo.TabIndex = 1;
            this.label_userInfo.Text = "Moduł obsługi technicznej i zleceń serwisu";
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(960, 18);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(100, 34);
            this.button_home.TabIndex = 2;
            this.button_home.Text = "Pulpit";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // panel_toolbar
            // 
            this.panel_toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_toolbar.Controls.Add(this.label_search);
            this.panel_toolbar.Controls.Add(this.textBox_search);
            this.panel_toolbar.Controls.Add(this.label_etapFilter);
            this.panel_toolbar.Controls.Add(this.comboBox_etapFilter);
            this.panel_toolbar.Controls.Add(this.label_mechanikFilter);
            this.panel_toolbar.Controls.Add(this.comboBox_mechanikFilter);
            this.panel_toolbar.Controls.Add(this.button_refresh);
            this.panel_toolbar.Location = new System.Drawing.Point(20, 85);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(1040, 50);
            this.panel_toolbar.TabIndex = 1;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search.ForeColor = System.Drawing.Color.White;
            this.label_search.Location = new System.Drawing.Point(12, 17);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(43, 15);
            this.label_search.TabIndex = 0;
            this.label_search.Text = "Szukaj:";
            // 
            // textBox_search
            // 
            this.textBox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_search.ForeColor = System.Drawing.Color.White;
            this.textBox_search.Location = new System.Drawing.Point(60, 14);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(180, 23);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label_etapFilter
            // 
            this.label_etapFilter.AutoSize = true;
            this.label_etapFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_etapFilter.ForeColor = System.Drawing.Color.White;
            this.label_etapFilter.Location = new System.Drawing.Point(260, 17);
            this.label_etapFilter.Name = "label_etapFilter";
            this.label_etapFilter.Size = new System.Drawing.Size(65, 15);
            this.label_etapFilter.TabIndex = 2;
            this.label_etapFilter.Text = "Etap pracy:";
            // 
            // comboBox_etapFilter
            // 
            this.comboBox_etapFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.comboBox_etapFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_etapFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_etapFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_etapFilter.ForeColor = System.Drawing.Color.White;
            this.comboBox_etapFilter.FormattingEnabled = true;
            this.comboBox_etapFilter.Items.AddRange(new object[] {
            "Wszystkie",
            "Przyjęty",
            "Diagnostyka",
            "Oczekiwanie na części",
            "W trakcie naprawy",
            "Testy końcowe",
            "Gotowy do odbioru",
            "Wydany"});
            this.comboBox_etapFilter.Location = new System.Drawing.Point(330, 14);
            this.comboBox_etapFilter.Name = "comboBox_etapFilter";
            this.comboBox_etapFilter.Size = new System.Drawing.Size(150, 21);
            this.comboBox_etapFilter.TabIndex = 3;
            this.comboBox_etapFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox_etapFilter_SelectedIndexChanged);
            // 
            // label_mechanikFilter
            // 
            this.label_mechanikFilter.AutoSize = true;
            this.label_mechanikFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_mechanikFilter.ForeColor = System.Drawing.Color.White;
            this.label_mechanikFilter.Location = new System.Drawing.Point(500, 17);
            this.label_mechanikFilter.Name = "label_mechanikFilter";
            this.label_mechanikFilter.Size = new System.Drawing.Size(62, 15);
            this.label_mechanikFilter.TabIndex = 4;
            this.label_mechanikFilter.Text = "Mechanik:";
            // 
            // comboBox_mechanikFilter
            // 
            this.comboBox_mechanikFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.comboBox_mechanikFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mechanikFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_mechanikFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_mechanikFilter.ForeColor = System.Drawing.Color.White;
            this.comboBox_mechanikFilter.FormattingEnabled = true;
            this.comboBox_mechanikFilter.Location = new System.Drawing.Point(568, 14);
            this.comboBox_mechanikFilter.Name = "comboBox_mechanikFilter";
            this.comboBox_mechanikFilter.Size = new System.Drawing.Size(160, 21);
            this.comboBox_mechanikFilter.TabIndex = 5;
            this.comboBox_mechanikFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox_mechanikFilter_SelectedIndexChanged);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.button_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(920, 12);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(100, 26);
            this.button_refresh.TabIndex = 6;
            this.button_refresh.Text = "Odśwież";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // dataGridView_repairs
            // 
            this.dataGridView_repairs.AllowUserToAddRows = false;
            this.dataGridView_repairs.AllowUserToDeleteRows = false;
            this.dataGridView_repairs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_repairs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dataGridView_repairs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_repairs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_repairs.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_repairs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_repairs.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.dataGridView_repairs.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_repairs.EnableHeadersVisualStyles = false;
            this.dataGridView_repairs.Location = new System.Drawing.Point(20, 145);
            this.dataGridView_repairs.MultiSelect = false;
            this.dataGridView_repairs.Name = "dataGridView_repairs";
            this.dataGridView_repairs.ReadOnly = true;
            this.dataGridView_repairs.RowHeadersVisible = false;
            this.dataGridView_repairs.RowTemplate.Height = 32;
            this.dataGridView_repairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_repairs.Size = new System.Drawing.Size(680, 440);
            this.dataGridView_repairs.TabIndex = 2;
            this.dataGridView_repairs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_repairs_CellFormatting);
            this.dataGridView_repairs.SelectionChanged += new System.EventHandler(this.dataGridView_repairs_SelectionChanged);
            // 
            // panel_edit
            // 
            this.panel_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_edit.Controls.Add(this.label_editHeader);
            this.panel_edit.Controls.Add(this.label_carSelected);
            this.panel_edit.Controls.Add(this.label_etap);
            this.panel_edit.Controls.Add(this.comboBox_etap);
            this.panel_edit.Controls.Add(this.label_mechanik);
            this.panel_edit.Controls.Add(this.comboBox_mechanik);
            this.panel_edit.Controls.Add(this.label_robocizna);
            this.panel_edit.Controls.Add(this.textBox_robocizna);
            this.panel_edit.Controls.Add(this.label_czesci);
            this.panel_edit.Controls.Add(this.textBox_czesci);
            this.panel_edit.Controls.Add(this.label_opis);
            this.panel_edit.Controls.Add(this.textBox_opis);
            this.panel_edit.Controls.Add(this.button_zapiszZlecenie);
            this.panel_edit.Controls.Add(this.label_sumaKoszt);
            this.panel_edit.Location = new System.Drawing.Point(715, 145);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(345, 440);
            this.panel_edit.TabIndex = 3;
            // 
            // label_editHeader
            // 
            this.label_editHeader.AutoSize = true;
            this.label_editHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_editHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label_editHeader.Location = new System.Drawing.Point(15, 12);
            this.label_editHeader.Name = "label_editHeader";
            this.label_editHeader.Size = new System.Drawing.Size(147, 21);
            this.label_editHeader.TabIndex = 0;
            this.label_editHeader.Text = "Obsługa zlecenia";
            // 
            // label_carSelected
            // 
            this.label_carSelected.AutoSize = true;
            this.label_carSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label_carSelected.Location = new System.Drawing.Point(16, 38);
            this.label_carSelected.Name = "label_carSelected";
            this.label_carSelected.Size = new System.Drawing.Size(155, 15);
            this.label_carSelected.TabIndex = 1;
            this.label_carSelected.Text = "Wybierz zlecenie z tabeli...";
            // 
            // label_etap
            // 
            this.label_etap.AutoSize = true;
            this.label_etap.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_etap.ForeColor = System.Drawing.Color.White;
            this.label_etap.Location = new System.Drawing.Point(16, 65);
            this.label_etap.Name = "label_etap";
            this.label_etap.Size = new System.Drawing.Size(77, 13);
            this.label_etap.TabIndex = 2;
            this.label_etap.Text = "Status / Etap:";
            // 
            // comboBox_etap
            // 
            this.comboBox_etap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.comboBox_etap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_etap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_etap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_etap.ForeColor = System.Drawing.Color.White;
            this.comboBox_etap.FormattingEnabled = true;
            this.comboBox_etap.Items.AddRange(new object[] {
            "Przyjęty",
            "Diagnostyka",
            "Oczekiwanie na części",
            "W trakcie naprawy",
            "Testy końcowe",
            "Gotowy do odbioru",
            "Wydany"});
            this.comboBox_etap.Location = new System.Drawing.Point(19, 82);
            this.comboBox_etap.Name = "comboBox_etap";
            this.comboBox_etap.Size = new System.Drawing.Size(310, 23);
            this.comboBox_etap.TabIndex = 3;
            // 
            // label_mechanik
            // 
            this.label_mechanik.AutoSize = true;
            this.label_mechanik.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_mechanik.ForeColor = System.Drawing.Color.White;
            this.label_mechanik.Location = new System.Drawing.Point(16, 115);
            this.label_mechanik.Name = "label_mechanik";
            this.label_mechanik.Size = new System.Drawing.Size(126, 13);
            this.label_mechanik.TabIndex = 4;
            this.label_mechanik.Text = "Przypisany pracownik:";
            // 
            // comboBox_mechanik
            // 
            this.comboBox_mechanik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.comboBox_mechanik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mechanik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_mechanik.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_mechanik.ForeColor = System.Drawing.Color.White;
            this.comboBox_mechanik.FormattingEnabled = true;
            this.comboBox_mechanik.Location = new System.Drawing.Point(19, 132);
            this.comboBox_mechanik.Name = "comboBox_mechanik";
            this.comboBox_mechanik.Size = new System.Drawing.Size(310, 23);
            this.comboBox_mechanik.TabIndex = 5;
            // 
            // label_robocizna
            // 
            this.label_robocizna.AutoSize = true;
            this.label_robocizna.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_robocizna.ForeColor = System.Drawing.Color.White;
            this.label_robocizna.Location = new System.Drawing.Point(16, 168);
            this.label_robocizna.Name = "label_robocizna";
            this.label_robocizna.Size = new System.Drawing.Size(117, 13);
            this.label_robocizna.TabIndex = 6;
            this.label_robocizna.Text = "Koszt robocizny (zł):";
            // 
            // textBox_robocizna
            // 
            this.textBox_robocizna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_robocizna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_robocizna.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_robocizna.ForeColor = System.Drawing.Color.White;
            this.textBox_robocizna.Location = new System.Drawing.Point(19, 185);
            this.textBox_robocizna.Name = "textBox_robocizna";
            this.textBox_robocizna.Size = new System.Drawing.Size(145, 23);
            this.textBox_robocizna.TabIndex = 7;
            this.textBox_robocizna.TextChanged += new System.EventHandler(this.Koszty_TextChanged);
            // 
            // label_czesci
            // 
            this.label_czesci.AutoSize = true;
            this.label_czesci.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_czesci.ForeColor = System.Drawing.Color.White;
            this.label_czesci.Location = new System.Drawing.Point(180, 168);
            this.label_czesci.Name = "label_czesci";
            this.label_czesci.Size = new System.Drawing.Size(95, 13);
            this.label_czesci.TabIndex = 8;
            this.label_czesci.Text = "Koszt części (zł):";
            // 
            // textBox_czesci
            // 
            this.textBox_czesci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_czesci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_czesci.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_czesci.ForeColor = System.Drawing.Color.White;
            this.textBox_czesci.Location = new System.Drawing.Point(184, 185);
            this.textBox_czesci.Name = "textBox_czesci";
            this.textBox_czesci.Size = new System.Drawing.Size(145, 23);
            this.textBox_czesci.TabIndex = 9;
            this.textBox_czesci.TextChanged += new System.EventHandler(this.Koszty_TextChanged);
            // 
            // label_opis
            // 
            this.label_opis.AutoSize = true;
            this.label_opis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_opis.ForeColor = System.Drawing.Color.White;
            this.label_opis.Location = new System.Drawing.Point(16, 220);
            this.label_opis.Name = "label_opis";
            this.label_opis.Size = new System.Drawing.Size(184, 13);
            this.label_opis.TabIndex = 10;
            this.label_opis.Text = "Zakres prac / notatki techniczne:";
            // 
            // textBox_opis
            // 
            this.textBox_opis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_opis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_opis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_opis.ForeColor = System.Drawing.Color.White;
            this.textBox_opis.Location = new System.Drawing.Point(19, 238);
            this.textBox_opis.Multiline = true;
            this.textBox_opis.Name = "textBox_opis";
            this.textBox_opis.Size = new System.Drawing.Size(310, 95);
            this.textBox_opis.TabIndex = 11;
            // 
            // button_zapiszZlecenie
            // 
            this.button_zapiszZlecenie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.button_zapiszZlecenie.FlatAppearance.BorderSize = 0;
            this.button_zapiszZlecenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zapiszZlecenie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zapiszZlecenie.ForeColor = System.Drawing.Color.White;
            this.button_zapiszZlecenie.Location = new System.Drawing.Point(19, 385);
            this.button_zapiszZlecenie.Name = "button_zapiszZlecenie";
            this.button_zapiszZlecenie.Size = new System.Drawing.Size(310, 36);
            this.button_zapiszZlecenie.TabIndex = 12;
            this.button_zapiszZlecenie.Text = "Zapisz zmiany w zleceniu";
            this.button_zapiszZlecenie.UseVisualStyleBackColor = false;
            this.button_zapiszZlecenie.Click += new System.EventHandler(this.button_zapiszZlecenie_Click);
            // 
            // label_sumaKoszt
            // 
            this.label_sumaKoszt.AutoSize = true;
            this.label_sumaKoszt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_sumaKoszt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.label_sumaKoszt.Location = new System.Drawing.Point(16, 350);
            this.label_sumaKoszt.Name = "label_sumaKoszt";
            this.label_sumaKoszt.Size = new System.Drawing.Size(176, 19);
            this.label_sumaKoszt.TabIndex = 13;
            this.label_sumaKoszt.Text = "Łączny koszt: 0,00 PLN";
            // 
            // repairsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1080, 605);
            this.Controls.Add(this.panel_edit);
            this.Controls.Add(this.dataGridView_repairs);
            this.Controls.Add(this.panel_toolbar);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "repairsManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarsztatDB - Zarządzanie Naprawami";
            this.Load += new System.EventHandler(this.repairsManagementForm_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_toolbar.ResumeLayout(false);
            this.panel_toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_repairs)).EndInit();
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Label label_userInfo;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Panel panel_toolbar;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label_etapFilter;
        private System.Windows.Forms.ComboBox comboBox_etapFilter;
        private System.Windows.Forms.Label label_mechanikFilter;
        private System.Windows.Forms.ComboBox comboBox_mechanikFilter;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridView dataGridView_repairs;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Label label_editHeader;
        private System.Windows.Forms.Label label_carSelected;
        private System.Windows.Forms.Label label_etap;
        private System.Windows.Forms.ComboBox comboBox_etap;
        private System.Windows.Forms.Label label_mechanik;
        private System.Windows.Forms.ComboBox comboBox_mechanik;
        private System.Windows.Forms.Label label_robocizna;
        private System.Windows.Forms.TextBox textBox_robocizna;
        private System.Windows.Forms.Label label_czesci;
        private System.Windows.Forms.TextBox textBox_czesci;
        private System.Windows.Forms.Label label_opis;
        private System.Windows.Forms.TextBox textBox_opis;
        private System.Windows.Forms.Button button_zapiszZlecenie;
        private System.Windows.Forms.Label label_sumaKoszt;
    }
}
