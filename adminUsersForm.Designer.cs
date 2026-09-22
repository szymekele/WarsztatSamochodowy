namespace WarsztatSamochodowy
{
    partial class adminUsersForm
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
            this.label_adminInfo = new System.Windows.Forms.Label();
            this.button_home = new System.Windows.Forms.Button();
            this.panel_toolbar = new System.Windows.Forms.Panel();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_roleFilter = new System.Windows.Forms.Label();
            this.comboBox_roleFilter = new System.Windows.Forms.ComboBox();
            this.label_zmienRole = new System.Windows.Forms.Label();
            this.comboBox_nowaRola = new System.Windows.Forms.ComboBox();
            this.button_zmienRole = new System.Windows.Forms.Button();
            this.button_resetHasla = new System.Windows.Forms.Button();
            this.button_usunKonto = new System.Windows.Forms.Button();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.label_count = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel_toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_top.Controls.Add(this.label_logo);
            this.panel_top.Controls.Add(this.label_adminInfo);
            this.panel_top.Controls.Add(this.button_home);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1020, 70);
            this.panel_top.TabIndex = 0;
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label_logo.Location = new System.Drawing.Point(12, 9);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(342, 32);
            this.label_logo.TabIndex = 0;
            this.label_logo.Text = "WarsztatDB - Panel Admina";
            // 
            // label_adminInfo
            // 
            this.label_adminInfo.AutoSize = true;
            this.label_adminInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_adminInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label_adminInfo.Location = new System.Drawing.Point(16, 43);
            this.label_adminInfo.Name = "label_adminInfo";
            this.label_adminInfo.Size = new System.Drawing.Size(225, 17);
            this.label_adminInfo.TabIndex = 1;
            this.label_adminInfo.Text = "Zarządzanie kontami użytkowników";
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(900, 18);
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
            this.panel_toolbar.Controls.Add(this.label_roleFilter);
            this.panel_toolbar.Controls.Add(this.comboBox_roleFilter);
            this.panel_toolbar.Controls.Add(this.label_zmienRole);
            this.panel_toolbar.Controls.Add(this.comboBox_nowaRola);
            this.panel_toolbar.Controls.Add(this.button_zmienRole);
            this.panel_toolbar.Controls.Add(this.button_resetHasla);
            this.panel_toolbar.Controls.Add(this.button_usunKonto);
            this.panel_toolbar.Location = new System.Drawing.Point(20, 85);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(980, 50);
            this.panel_toolbar.TabIndex = 1;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search.ForeColor = System.Drawing.Color.White;
            this.label_search.Location = new System.Drawing.Point(10, 17);
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
            this.textBox_search.Location = new System.Drawing.Point(55, 14);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(150, 23);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label_roleFilter
            // 
            this.label_roleFilter.AutoSize = true;
            this.label_roleFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_roleFilter.ForeColor = System.Drawing.Color.White;
            this.label_roleFilter.Location = new System.Drawing.Point(215, 17);
            this.label_roleFilter.Name = "label_roleFilter";
            this.label_roleFilter.Size = new System.Drawing.Size(33, 15);
            this.label_roleFilter.TabIndex = 2;
            this.label_roleFilter.Text = "Rola:";
            // 
            // comboBox_roleFilter
            // 
            this.comboBox_roleFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.comboBox_roleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_roleFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_roleFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_roleFilter.ForeColor = System.Drawing.Color.White;
            this.comboBox_roleFilter.FormattingEnabled = true;
            this.comboBox_roleFilter.Items.AddRange(new object[] {
            "Wszyscy",
            "Administrator",
            "Pracownik",
            "Klient"});
            this.comboBox_roleFilter.Location = new System.Drawing.Point(252, 14);
            this.comboBox_roleFilter.Name = "comboBox_roleFilter";
            this.comboBox_roleFilter.Size = new System.Drawing.Size(110, 21);
            this.comboBox_roleFilter.TabIndex = 3;
            this.comboBox_roleFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox_roleFilter_SelectedIndexChanged);
            // 
            // label_zmienRole
            // 
            this.label_zmienRole.AutoSize = true;
            this.label_zmienRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_zmienRole.ForeColor = System.Drawing.Color.White;
            this.label_zmienRole.Location = new System.Drawing.Point(380, 17);
            this.label_zmienRole.Name = "label_zmienRole";
            this.label_zmienRole.Size = new System.Drawing.Size(64, 15);
            this.label_zmienRole.TabIndex = 4;
            this.label_zmienRole.Text = "Ustaw rolę:";
            // 
            // comboBox_nowaRola
            // 
            this.comboBox_nowaRola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.comboBox_nowaRola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nowaRola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_nowaRola.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_nowaRola.ForeColor = System.Drawing.Color.White;
            this.comboBox_nowaRola.FormattingEnabled = true;
            this.comboBox_nowaRola.Items.AddRange(new object[] {
            "Klient",
            "Pracownik",
            "Administrator"});
            this.comboBox_nowaRola.Location = new System.Drawing.Point(448, 14);
            this.comboBox_nowaRola.Name = "comboBox_nowaRola";
            this.comboBox_nowaRola.Size = new System.Drawing.Size(110, 21);
            this.comboBox_nowaRola.TabIndex = 5;
            // 
            // button_zmienRole
            // 
            this.button_zmienRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.button_zmienRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_zmienRole.FlatAppearance.BorderSize = 0;
            this.button_zmienRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zmienRole.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zmienRole.ForeColor = System.Drawing.Color.White;
            this.button_zmienRole.Location = new System.Drawing.Point(565, 12);
            this.button_zmienRole.Name = "button_zmienRole";
            this.button_zmienRole.Size = new System.Drawing.Size(95, 26);
            this.button_zmienRole.TabIndex = 6;
            this.button_zmienRole.Text = "Zapisz rolę";
            this.button_zmienRole.UseVisualStyleBackColor = false;
            this.button_zmienRole.Click += new System.EventHandler(this.button_zmienRole_Click);
            // 
            // button_resetHasla
            // 
            this.button_resetHasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.button_resetHasla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_resetHasla.FlatAppearance.BorderSize = 0;
            this.button_resetHasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_resetHasla.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_resetHasla.ForeColor = System.Drawing.Color.White;
            this.button_resetHasla.Location = new System.Drawing.Point(670, 12);
            this.button_resetHasla.Name = "button_resetHasla";
            this.button_resetHasla.Size = new System.Drawing.Size(110, 26);
            this.button_resetHasla.TabIndex = 7;
            this.button_resetHasla.Text = "Resetuj hasło";
            this.button_resetHasla.UseVisualStyleBackColor = false;
            this.button_resetHasla.Click += new System.EventHandler(this.button_resetHasla_Click);
            // 
            // button_usunKonto
            // 
            this.button_usunKonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_usunKonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_usunKonto.FlatAppearance.BorderSize = 0;
            this.button_usunKonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_usunKonto.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usunKonto.ForeColor = System.Drawing.Color.White;
            this.button_usunKonto.Location = new System.Drawing.Point(790, 12);
            this.button_usunKonto.Name = "button_usunKonto";
            this.button_usunKonto.Size = new System.Drawing.Size(100, 26);
            this.button_usunKonto.TabIndex = 8;
            this.button_usunKonto.Text = "Usuń konto";
            this.button_usunKonto.UseVisualStyleBackColor = false;
            this.button_usunKonto.Click += new System.EventHandler(this.button_usunKonto_Click);
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.AllowUserToAddRows = false;
            this.dataGridView_users.AllowUserToDeleteRows = false;
            this.dataGridView_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dataGridView_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_users.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_users.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_users.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.dataGridView_users.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_users.EnableHeadersVisualStyles = false;
            this.dataGridView_users.Location = new System.Drawing.Point(20, 150);
            this.dataGridView_users.MultiSelect = false;
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.ReadOnly = true;
            this.dataGridView_users.RowHeadersVisible = false;
            this.dataGridView_users.RowTemplate.Height = 32;
            this.dataGridView_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_users.Size = new System.Drawing.Size(980, 390);
            this.dataGridView_users.TabIndex = 2;
            this.dataGridView_users.SelectionChanged += new System.EventHandler(this.dataGridView_users_SelectionChanged);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_count.Location = new System.Drawing.Point(22, 550);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(147, 15);
            this.label_count.TabIndex = 3;
            this.label_count.Text = "Łącznie użytkowników: 0";
            // 
            // adminUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1020, 580);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.dataGridView_users);
            this.Controls.Add(this.panel_toolbar);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "adminUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarsztatDB - Panel Administratora";
            this.Load += new System.EventHandler(this.adminUsersForm_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_toolbar.ResumeLayout(false);
            this.panel_toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Label label_adminInfo;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Panel panel_toolbar;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label_roleFilter;
        private System.Windows.Forms.ComboBox comboBox_roleFilter;
        private System.Windows.Forms.Label label_zmienRole;
        private System.Windows.Forms.ComboBox comboBox_nowaRola;
        private System.Windows.Forms.Button button_zmienRole;
        private System.Windows.Forms.Button button_resetHasla;
        private System.Windows.Forms.Button button_usunKonto;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.Label label_count;
    }
}
