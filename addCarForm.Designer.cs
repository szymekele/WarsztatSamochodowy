namespace WarsztatSamochodowy
{
    partial class addCarForm
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
            this.button_anulujTop = new System.Windows.Forms.Button();
            this.panel_card = new System.Windows.Forms.Panel();
            this.label_header = new System.Windows.Forms.Label();
            this.label_subheader = new System.Windows.Forms.Label();
            this.label_marka = new System.Windows.Forms.Label();
            this.textBox_marka = new System.Windows.Forms.TextBox();
            this.label_model = new System.Windows.Forms.Label();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.label_rok = new System.Windows.Forms.Label();
            this.maskedTextBox_rokprodukcji = new System.Windows.Forms.MaskedTextBox();
            this.label_nrRej = new System.Windows.Forms.Label();
            this.textBox_numerrejestracyjny = new System.Windows.Forms.TextBox();
            this.label_vin = new System.Windows.Forms.Label();
            this.textBox_vin = new System.Windows.Forms.TextBox();
            this.label_opis = new System.Windows.Forms.Label();
            this.textBox_opisuszkodzen = new System.Windows.Forms.TextBox();
            this.label_uwagi = new System.Windows.Forms.Label();
            this.textBox_uwagi = new System.Windows.Forms.TextBox();
            this.button_dodajsamochod = new System.Windows.Forms.Button();
            this.label_cofnij = new System.Windows.Forms.Label();
            this.label_wymagane = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel_card.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_top.Controls.Add(this.label_logo);
            this.panel_top.Controls.Add(this.label_uzytkownik);
            this.panel_top.Controls.Add(this.button_anulujTop);
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
            // button_anulujTop
            // 
            this.button_anulujTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.button_anulujTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_anulujTop.FlatAppearance.BorderSize = 0;
            this.button_anulujTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anulujTop.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_anulujTop.ForeColor = System.Drawing.Color.White;
            this.button_anulujTop.Location = new System.Drawing.Point(710, 18);
            this.button_anulujTop.Name = "button_anulujTop";
            this.button_anulujTop.Size = new System.Drawing.Size(115, 34);
            this.button_anulujTop.TabIndex = 20;
            this.button_anulujTop.Text = "Wróć do listy";
            this.button_anulujTop.UseVisualStyleBackColor = false;
            this.button_anulujTop.Click += new System.EventHandler(this.label_cofnij_Click);
            // 
            // panel_card
            // 
            this.panel_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_card.Controls.Add(this.label_header);
            this.panel_card.Controls.Add(this.label_subheader);
            this.panel_card.Controls.Add(this.label_marka);
            this.panel_card.Controls.Add(this.textBox_marka);
            this.panel_card.Controls.Add(this.label_model);
            this.panel_card.Controls.Add(this.textBox_model);
            this.panel_card.Controls.Add(this.label_rok);
            this.panel_card.Controls.Add(this.maskedTextBox_rokprodukcji);
            this.panel_card.Controls.Add(this.label_nrRej);
            this.panel_card.Controls.Add(this.textBox_numerrejestracyjny);
            this.panel_card.Controls.Add(this.label_vin);
            this.panel_card.Controls.Add(this.textBox_vin);
            this.panel_card.Controls.Add(this.label_opis);
            this.panel_card.Controls.Add(this.textBox_opisuszkodzen);
            this.panel_card.Controls.Add(this.label_uwagi);
            this.panel_card.Controls.Add(this.textBox_uwagi);
            this.panel_card.Controls.Add(this.button_dodajsamochod);
            this.panel_card.Controls.Add(this.label_cofnij);
            this.panel_card.Controls.Add(this.label_wymagane);
            this.panel_card.Location = new System.Drawing.Point(20, 90);
            this.panel_card.Name = "panel_card";
            this.panel_card.Size = new System.Drawing.Size(810, 480);
            this.panel_card.TabIndex = 1;
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_header.ForeColor = System.Drawing.Color.White;
            this.label_header.Location = new System.Drawing.Point(25, 20);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(269, 30);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Rejestracja nowego auta";
            // 
            // label_subheader
            // 
            this.label_subheader.AutoSize = true;
            this.label_subheader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_subheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_subheader.Location = new System.Drawing.Point(27, 52);
            this.label_subheader.Name = "label_subheader";
            this.label_subheader.Size = new System.Drawing.Size(434, 17);
            this.label_subheader.TabIndex = 1;
            this.label_subheader.Text = "Wypełnij dane pojazdu. Pojazd zostanie przypisany do Twojego konta klienta.";
            // 
            // label_marka
            // 
            this.label_marka.AutoSize = true;
            this.label_marka.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_marka.ForeColor = System.Drawing.Color.White;
            this.label_marka.Location = new System.Drawing.Point(30, 95);
            this.label_marka.Name = "label_marka";
            this.label_marka.Size = new System.Drawing.Size(56, 17);
            this.label_marka.TabIndex = 2;
            this.label_marka.Text = "Marka *:";
            // 
            // textBox_marka
            // 
            this.textBox_marka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_marka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_marka.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_marka.ForeColor = System.Drawing.Color.White;
            this.textBox_marka.Location = new System.Drawing.Point(30, 115);
            this.textBox_marka.Name = "textBox_marka";
            this.textBox_marka.Size = new System.Drawing.Size(340, 25);
            this.textBox_marka.TabIndex = 3;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_model.ForeColor = System.Drawing.Color.White;
            this.label_model.Location = new System.Drawing.Point(30, 155);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(57, 17);
            this.label_model.TabIndex = 4;
            this.label_model.Text = "Model *:";
            // 
            // textBox_model
            // 
            this.textBox_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_model.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_model.ForeColor = System.Drawing.Color.White;
            this.textBox_model.Location = new System.Drawing.Point(30, 175);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(340, 25);
            this.textBox_model.TabIndex = 5;
            // 
            // label_rok
            // 
            this.label_rok.AutoSize = true;
            this.label_rok.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rok.ForeColor = System.Drawing.Color.White;
            this.label_rok.Location = new System.Drawing.Point(30, 215);
            this.label_rok.Name = "label_rok";
            this.label_rok.Size = new System.Drawing.Size(91, 17);
            this.label_rok.TabIndex = 6;
            this.label_rok.Text = "Rok produkcji:";
            // 
            // maskedTextBox_rokprodukcji
            // 
            this.maskedTextBox_rokprodukcji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.maskedTextBox_rokprodukcji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox_rokprodukcji.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBox_rokprodukcji.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox_rokprodukcji.Location = new System.Drawing.Point(30, 235);
            this.maskedTextBox_rokprodukcji.Mask = "0000";
            this.maskedTextBox_rokprodukcji.Name = "maskedTextBox_rokprodukcji";
            this.maskedTextBox_rokprodukcji.Size = new System.Drawing.Size(340, 25);
            this.maskedTextBox_rokprodukcji.TabIndex = 7;
            this.maskedTextBox_rokprodukcji.ValidatingType = typeof(System.DateTime);
            // 
            // label_nrRej
            // 
            this.label_nrRej.AutoSize = true;
            this.label_nrRej.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nrRej.ForeColor = System.Drawing.Color.White;
            this.label_nrRej.Location = new System.Drawing.Point(30, 275);
            this.label_nrRej.Name = "label_nrRej";
            this.label_nrRej.Size = new System.Drawing.Size(138, 17);
            this.label_nrRej.TabIndex = 8;
            this.label_nrRej.Text = "Numer rejestracyjny *:";
            // 
            // textBox_numerrejestracyjny
            // 
            this.textBox_numerrejestracyjny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_numerrejestracyjny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_numerrejestracyjny.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_numerrejestracyjny.ForeColor = System.Drawing.Color.White;
            this.textBox_numerrejestracyjny.Location = new System.Drawing.Point(30, 295);
            this.textBox_numerrejestracyjny.Name = "textBox_numerrejestracyjny";
            this.textBox_numerrejestracyjny.Size = new System.Drawing.Size(340, 25);
            this.textBox_numerrejestracyjny.TabIndex = 9;
            // 
            // label_vin
            // 
            this.label_vin.AutoSize = true;
            this.label_vin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_vin.ForeColor = System.Drawing.Color.White;
            this.label_vin.Location = new System.Drawing.Point(420, 95);
            this.label_vin.Name = "label_vin";
            this.label_vin.Size = new System.Drawing.Size(73, 17);
            this.label_vin.TabIndex = 10;
            this.label_vin.Text = "Numer VIN:";
            // 
            // textBox_vin
            // 
            this.textBox_vin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_vin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_vin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_vin.ForeColor = System.Drawing.Color.White;
            this.textBox_vin.Location = new System.Drawing.Point(420, 115);
            this.textBox_vin.MaxLength = 17;
            this.textBox_vin.Name = "textBox_vin";
            this.textBox_vin.Size = new System.Drawing.Size(350, 25);
            this.textBox_vin.TabIndex = 11;
            // 
            // label_opis
            // 
            this.label_opis.AutoSize = true;
            this.label_opis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_opis.ForeColor = System.Drawing.Color.White;
            this.label_opis.Location = new System.Drawing.Point(420, 155);
            this.label_opis.Name = "label_opis";
            this.label_opis.Size = new System.Drawing.Size(183, 17);
            this.label_opis.TabIndex = 12;
            this.label_opis.Text = "Opis usterki / uszkodzeń:";
            // 
            // textBox_opisuszkodzen
            // 
            this.textBox_opisuszkodzen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_opisuszkodzen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_opisuszkodzen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_opisuszkodzen.ForeColor = System.Drawing.Color.White;
            this.textBox_opisuszkodzen.Location = new System.Drawing.Point(420, 175);
            this.textBox_opisuszkodzen.Multiline = true;
            this.textBox_opisuszkodzen.Name = "textBox_opisuszkodzen";
            this.textBox_opisuszkodzen.Size = new System.Drawing.Size(350, 50);
            this.textBox_opisuszkodzen.TabIndex = 13;
            // 
            // label_uwagi
            // 
            this.label_uwagi.AutoSize = true;
            this.label_uwagi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_uwagi.ForeColor = System.Drawing.Color.White;
            this.label_uwagi.Location = new System.Drawing.Point(420, 235);
            this.label_uwagi.Name = "label_uwagi";
            this.label_uwagi.Size = new System.Drawing.Size(107, 17);
            this.label_uwagi.TabIndex = 14;
            this.label_uwagi.Text = "Uwagi dodatkowe:";
            // 
            // textBox_uwagi
            // 
            this.textBox_uwagi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox_uwagi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_uwagi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_uwagi.ForeColor = System.Drawing.Color.White;
            this.textBox_uwagi.Location = new System.Drawing.Point(420, 255);
            this.textBox_uwagi.Multiline = true;
            this.textBox_uwagi.Name = "textBox_uwagi";
            this.textBox_uwagi.Size = new System.Drawing.Size(350, 65);
            this.textBox_uwagi.TabIndex = 15;
            // 
            // button_dodajsamochod
            // 
            this.button_dodajsamochod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.button_dodajsamochod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dodajsamochod.FlatAppearance.BorderSize = 0;
            this.button_dodajsamochod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dodajsamochod.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodajsamochod.ForeColor = System.Drawing.Color.White;
            this.button_dodajsamochod.Location = new System.Drawing.Point(570, 410);
            this.button_dodajsamochod.Name = "button_dodajsamochod";
            this.button_dodajsamochod.Size = new System.Drawing.Size(200, 38);
            this.button_dodajsamochod.TabIndex = 16;
            this.button_dodajsamochod.Text = "+ Dodaj pojazd do bazy";
            this.button_dodajsamochod.UseVisualStyleBackColor = false;
            this.button_dodajsamochod.Click += new System.EventHandler(this.button_dodajsamochod_Click);
            // 
            // label_cofnij
            // 
            this.label_cofnij.AutoSize = true;
            this.label_cofnij.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_cofnij.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cofnij.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_cofnij.Location = new System.Drawing.Point(400, 420);
            this.label_cofnij.Name = "label_cofnij";
            this.label_cofnij.Size = new System.Drawing.Size(150, 17);
            this.label_cofnij.TabIndex = 17;
            this.label_cofnij.Text = "Anuluj i wróć do pojazdów";
            this.label_cofnij.Click += new System.EventHandler(this.label_cofnij_Click);
            // 
            // label_wymagane
            // 
            this.label_wymagane.AutoSize = true;
            this.label_wymagane.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wymagane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.label_wymagane.Location = new System.Drawing.Point(30, 422);
            this.label_wymagane.Name = "label_wymagane";
            this.label_wymagane.Size = new System.Drawing.Size(227, 15);
            this.label_wymagane.TabIndex = 18;
            this.label_wymagane.Text = "* Pola oznaczone gwiazdką są obowiązkowe.";
            // 
            // addCarForm
            // 
            this.AcceptButton = this.button_dodajsamochod;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(850, 590);
            this.Controls.Add(this.panel_card);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarsztatDB - Dodawanie nowego pojazdu";
            this.Load += new System.EventHandler(this.addCarForm_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_card.ResumeLayout(false);
            this.panel_card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Label label_uzytkownik;
        private System.Windows.Forms.Button button_anulujTop;
        private System.Windows.Forms.Panel panel_card;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label_subheader;
        private System.Windows.Forms.Label label_marka;
        private System.Windows.Forms.TextBox textBox_marka;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.Label label_rok;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_rokprodukcji;
        private System.Windows.Forms.Label label_nrRej;
        private System.Windows.Forms.TextBox textBox_numerrejestracyjny;
        private System.Windows.Forms.Label label_vin;
        private System.Windows.Forms.TextBox textBox_vin;
        private System.Windows.Forms.Label label_opis;
        private System.Windows.Forms.TextBox textBox_opisuszkodzen;
        private System.Windows.Forms.Label label_uwagi;
        private System.Windows.Forms.TextBox textBox_uwagi;
        private System.Windows.Forms.Button button_dodajsamochod;
        private System.Windows.Forms.Label label_cofnij;
        private System.Windows.Forms.Label label_wymagane;
    }
}