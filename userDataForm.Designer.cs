namespace WarsztatSamochodowy
{
    partial class userDataForm
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_logo = new System.Windows.Forms.Label();
            this.label_uzytkownik = new System.Windows.Forms.Label();
            this.button_home = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.panel_card = new System.Windows.Forms.Panel();
            this.label_header = new System.Windows.Forms.Label();
            this.label_subheader = new System.Windows.Forms.Label();
            this.groupBox_account = new System.Windows.Forms.GroupBox();
            this.label_imieNazwiskoVal = new System.Windows.Forms.Label();
            this.label_imieNazwisko = new System.Windows.Forms.Label();
            this.label_loginVal = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_rolaVal = new System.Windows.Forms.Label();
            this.label_rola = new System.Windows.Forms.Label();
            this.label_datarejestracjiVal = new System.Windows.Forms.Label();
            this.label_datarejestracji = new System.Windows.Forms.Label();
            this.groupBox_contact = new System.Windows.Forms.GroupBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_telefon = new System.Windows.Forms.Label();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.label_adres = new System.Windows.Forms.Label();
            this.textBox_adres = new System.Windows.Forms.TextBox();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel_card.SuspendLayout();
            this.groupBox_account.SuspendLayout();
            this.groupBox_contact.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_top.Controls.Add(this.label_logo);
            this.panel_top.Controls.Add(this.label_uzytkownik);
            this.panel_top.Controls.Add(this.button_home);
            this.panel_top.Controls.Add(this.button_logout);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(850, 70);
            this.panel_top.TabIndex = 0;
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label_logo.Location = new System.Drawing.Point(12, 6);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(170, 37);
            this.label_logo.TabIndex = 11;
            this.label_logo.Text = "WarsztatDB";
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
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.button_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(610, 18);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(100, 34);
            this.button_home.TabIndex = 10;
            this.button_home.Text = "Pulpit";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(725, 18);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(100, 34);
            this.button_logout.TabIndex = 11;
            this.button_logout.Text = "Wyloguj";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // panel_card
            // 
            this.panel_card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_card.Controls.Add(this.label_header);
            this.panel_card.Controls.Add(this.label_subheader);
            this.panel_card.Controls.Add(this.groupBox_account);
            this.panel_card.Controls.Add(this.groupBox_contact);
            this.panel_card.Controls.Add(this.button_zapisz);
            this.panel_card.Controls.Add(this.label_info);
            this.panel_card.Location = new System.Drawing.Point(20, 90);
            this.panel_card.Name = "panel_card";
            this.panel_card.Size = new System.Drawing.Size(805, 430);
            this.panel_card.TabIndex = 1;
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_header.ForeColor = System.Drawing.Color.White;
            this.label_header.Location = new System.Drawing.Point(25, 20);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(182, 30);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Profil Użytkownika";
            // 
            // label_subheader
            // 
            this.label_subheader.AutoSize = true;
            this.label_subheader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_subheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_subheader.Location = new System.Drawing.Point(27, 52);
            this.label_subheader.Name = "label_subheader";
            this.label_subheader.Size = new System.Drawing.Size(323, 17);
            this.label_subheader.TabIndex = 1;
            this.label_subheader.Text = "Możesz zaktualizować swój adres e-mail, telefon i adres.";
            // 
            // groupBox_account
            // 
            this.groupBox_account.Controls.Add(this.label_imieNazwiskoVal);
            this.groupBox_account.Controls.Add(this.label_imieNazwisko);
            this.groupBox_account.Controls.Add(this.label_loginVal);
            this.groupBox_account.Controls.Add(this.label_login);
            this.groupBox_account.Controls.Add(this.label_rolaVal);
            this.groupBox_account.Controls.Add(this.label_rola);
            this.groupBox_account.Controls.Add(this.label_datarejestracjiVal);
            this.groupBox_account.Controls.Add(this.label_datarejestracji);
            this.groupBox_account.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.groupBox_account.Location = new System.Drawing.Point(30, 85);
            this.groupBox_account.Name = "groupBox_account";
            this.groupBox_account.Size = new System.Drawing.Size(345, 275);
            this.groupBox_account.TabIndex = 2;
            this.groupBox_account.TabStop = false;
            this.groupBox_account.Text = "Dane konta (tylko do odczytu)";
            // 
            // label_imieNazwiskoVal
            // 
            this.label_imieNazwiskoVal.AutoSize = true;
            this.label_imieNazwiskoVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_imieNazwiskoVal.ForeColor = System.Drawing.Color.White;
            this.label_imieNazwiskoVal.Location = new System.Drawing.Point(20, 55);
            this.label_imieNazwiskoVal.Name = "label_imieNazwiskoVal";
            this.label_imieNazwiskoVal.Size = new System.Drawing.Size(31, 19);
            this.label_imieNazwiskoVal.TabIndex = 1;
            this.label_imieNazwiskoVal.Text = "null";
            // 
            // label_imieNazwisko
            // 
            this.label_imieNazwisko.AutoSize = true;
            this.label_imieNazwisko.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_imieNazwisko.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_imieNazwisko.Location = new System.Drawing.Point(20, 38);
            this.label_imieNazwisko.Name = "label_imieNazwisko";
            this.label_imieNazwisko.Size = new System.Drawing.Size(89, 13);
            this.label_imieNazwisko.TabIndex = 0;
            this.label_imieNazwisko.Text = "Imię i Nazwisko:";
            // 
            // label_loginVal
            // 
            this.label_loginVal.AutoSize = true;
            this.label_loginVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_loginVal.ForeColor = System.Drawing.Color.White;
            this.label_loginVal.Location = new System.Drawing.Point(20, 110);
            this.label_loginVal.Name = "label_loginVal";
            this.label_loginVal.Size = new System.Drawing.Size(31, 19);
            this.label_loginVal.TabIndex = 3;
            this.label_loginVal.Text = "null";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_login.Location = new System.Drawing.Point(20, 93);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(39, 13);
            this.label_login.TabIndex = 2;
            this.label_login.Text = "Login:";
            // 
            // label_rolaVal
            // 
            this.label_rolaVal.AutoSize = true;
            this.label_rolaVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rolaVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.label_rolaVal.Location = new System.Drawing.Point(20, 168);
            this.label_rolaVal.Name = "label_rolaVal";
            this.label_rolaVal.Size = new System.Drawing.Size(34, 19);
            this.label_rolaVal.TabIndex = 5;
            this.label_rolaVal.Text = "null";
            // 
            // label_rola
            // 
            this.label_rola.AutoSize = true;
            this.label_rola.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_rola.Location = new System.Drawing.Point(20, 151);
            this.label_rola.Name = "label_rola";
            this.label_rola.Size = new System.Drawing.Size(91, 13);
            this.label_rola.TabIndex = 4;
            this.label_rola.Text = "Rola w systemie:";
            // 
            // label_datarejestracjiVal
            // 
            this.label_datarejestracjiVal.AutoSize = true;
            this.label_datarejestracjiVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_datarejestracjiVal.ForeColor = System.Drawing.Color.White;
            this.label_datarejestracjiVal.Location = new System.Drawing.Point(20, 226);
            this.label_datarejestracjiVal.Name = "label_datarejestracjiVal";
            this.label_datarejestracjiVal.Size = new System.Drawing.Size(31, 19);
            this.label_datarejestracjiVal.TabIndex = 7;
            this.label_datarejestracjiVal.Text = "null";
            // 
            // label_datarejestracji
            // 
            this.label_datarejestracji.AutoSize = true;
            this.label_datarejestracji.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_datarejestracji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_datarejestracji.Location = new System.Drawing.Point(20, 209);
            this.label_datarejestracji.Name = "label_datarejestracji";
            this.label_datarejestracji.Size = new System.Drawing.Size(89, 13);
            this.label_datarejestracji.TabIndex = 6;
            this.label_datarejestracji.Text = "Data rejestracji:";
            // 
            // groupBox_contact
            // 
            this.groupBox_contact.Controls.Add(this.label_email);
            this.groupBox_contact.Controls.Add(this.textBox_email);
            this.groupBox_contact.Controls.Add(this.label_telefon);
            this.groupBox_contact.Controls.Add(this.textBox_telefon);
            this.groupBox_contact.Controls.Add(this.label_adres);
            this.groupBox_contact.Controls.Add(this.textBox_adres);
            this.groupBox_contact.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.groupBox_contact.Location = new System.Drawing.Point(400, 85);
            this.groupBox_contact.Name = "groupBox_contact";
            this.groupBox_contact.Size = new System.Drawing.Size(375, 275);
            this.groupBox_contact.TabIndex = 3;
            this.groupBox_contact.TabStop = false;
            this.groupBox_contact.Text = "Dane kontaktowe (edytowalne)";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_email.Location = new System.Drawing.Point(20, 38);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(73, 13);
            this.label_email.TabIndex = 0;
            this.label_email.Text = "Adres E-mail:";
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_email.ForeColor = System.Drawing.Color.White;
            this.textBox_email.Location = new System.Drawing.Point(23, 55);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(330, 25);
            this.textBox_email.TabIndex = 1;
            // 
            // label_telefon
            // 
            this.label_telefon.AutoSize = true;
            this.label_telefon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_telefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_telefon.Location = new System.Drawing.Point(20, 93);
            this.label_telefon.Name = "label_telefon";
            this.label_telefon.Size = new System.Drawing.Size(91, 13);
            this.label_telefon.TabIndex = 2;
            this.label_telefon.Text = "Numer Telefonu:";
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_telefon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_telefon.ForeColor = System.Drawing.Color.White;
            this.textBox_telefon.Location = new System.Drawing.Point(23, 110);
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(330, 25);
            this.textBox_telefon.TabIndex = 3;
            // 
            // label_adres
            // 
            this.label_adres.AutoSize = true;
            this.label_adres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_adres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_adres.Location = new System.Drawing.Point(20, 151);
            this.label_adres.Name = "label_adres";
            this.label_adres.Size = new System.Drawing.Size(108, 13);
            this.label_adres.TabIndex = 4;
            this.label_adres.Text = "Adres zamieszkania:";
            // 
            // textBox_adres
            // 
            this.textBox_adres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_adres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_adres.ForeColor = System.Drawing.Color.White;
            this.textBox_adres.Location = new System.Drawing.Point(23, 168);
            this.textBox_adres.Multiline = true;
            this.textBox_adres.Name = "textBox_adres";
            this.textBox_adres.Size = new System.Drawing.Size(330, 80);
            this.textBox_adres.TabIndex = 5;
            // 
            // button_zapisz
            // 
            this.button_zapisz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.button_zapisz.FlatAppearance.BorderSize = 0;
            this.button_zapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zapisz.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zapisz.ForeColor = System.Drawing.Color.White;
            this.button_zapisz.Location = new System.Drawing.Point(595, 375);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(180, 36);
            this.button_zapisz.TabIndex = 4;
            this.button_zapisz.Text = "Zapisz zmiany";
            this.button_zapisz.UseVisualStyleBackColor = false;
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.label_info.Location = new System.Drawing.Point(30, 386);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(0, 15);
            this.label_info.TabIndex = 5;
            // 
            // userDataForm
            // 
            this.AcceptButton = this.button_zapisz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(850, 545);
            this.Controls.Add(this.panel_card);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "userDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarsztatDB - Twój Profil";
            this.Load += new System.EventHandler(this.userDataForm_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_card.ResumeLayout(false);
            this.panel_card.PerformLayout();
            this.groupBox_account.ResumeLayout(false);
            this.groupBox_account.PerformLayout();
            this.groupBox_contact.ResumeLayout(false);
            this.groupBox_contact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Label label_uzytkownik;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel panel_card;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label_subheader;
        private System.Windows.Forms.GroupBox groupBox_account;
        private System.Windows.Forms.Label label_imieNazwiskoVal;
        private System.Windows.Forms.Label label_imieNazwisko;
        private System.Windows.Forms.Label label_loginVal;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_rolaVal;
        private System.Windows.Forms.Label label_rola;
        private System.Windows.Forms.Label label_datarejestracjiVal;
        private System.Windows.Forms.Label label_datarejestracji;
        private System.Windows.Forms.GroupBox groupBox_contact;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_telefon;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.Label label_adres;
        private System.Windows.Forms.TextBox textBox_adres;
        private System.Windows.Forms.Button button_zapisz;
        private System.Windows.Forms.Label label_info;
    }
}