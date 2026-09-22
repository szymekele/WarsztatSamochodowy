namespace WarsztatSamochodowy
{
    partial class loginForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_brand = new System.Windows.Forms.Panel();
            this.label_brandTagline = new System.Windows.Forms.Label();
            this.label_brandSubtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_loginCard = new System.Windows.Forms.Panel();
            this.label_loginSubtitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_nextform = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.panel_brand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_loginCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_brand
            // 
            this.panel_brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panel_brand.Controls.Add(this.label_brandTagline);
            this.panel_brand.Controls.Add(this.label_brandSubtitle);
            this.panel_brand.Controls.Add(this.label1);
            this.panel_brand.Controls.Add(this.pictureBox1);
            this.panel_brand.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_brand.Location = new System.Drawing.Point(0, 0);
            this.panel_brand.Name = "panel_brand";
            this.panel_brand.Size = new System.Drawing.Size(350, 480);
            this.panel_brand.TabIndex = 10;
            // 
            // label_brandTagline
            // 
            this.label_brandTagline.AutoSize = true;
            this.label_brandTagline.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brandTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_brandTagline.Location = new System.Drawing.Point(24, 435);
            this.label_brandTagline.Name = "label_brandTagline";
            this.label_brandTagline.Size = new System.Drawing.Size(258, 13);
            this.label_brandTagline.TabIndex = 3;
            this.label_brandTagline.Text = "Bezpieczeństwo SHA-256 • Szybkość • Wygoda";
            // 
            // label_brandSubtitle
            // 
            this.label_brandSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brandSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label_brandSubtitle.Location = new System.Drawing.Point(24, 80);
            this.label_brandSubtitle.Name = "label_brandSubtitle";
            this.label_brandSubtitle.Size = new System.Drawing.Size(295, 45);
            this.label_brandSubtitle.TabIndex = 2;
            this.label_brandSubtitle.Text = "Nowoczesny system zarządzania serwisem samochodowym i naprawami pojazdów.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "WarsztatDB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarsztatSamochodowy.Properties.Resources.car;
            this.pictureBox1.Location = new System.Drawing.Point(20, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel_loginCard
            // 
            this.panel_loginCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel_loginCard.Controls.Add(this.label_loginSubtitle);
            this.panel_loginCard.Controls.Add(this.label2);
            this.panel_loginCard.Controls.Add(this.label3);
            this.panel_loginCard.Controls.Add(this.textBox_login);
            this.panel_loginCard.Controls.Add(this.label4);
            this.panel_loginCard.Controls.Add(this.textBox_password);
            this.panel_loginCard.Controls.Add(this.button_login);
            this.panel_loginCard.Controls.Add(this.label_nextform);
            this.panel_loginCard.Controls.Add(this.button_close);
            this.panel_loginCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_loginCard.Location = new System.Drawing.Point(350, 0);
            this.panel_loginCard.Name = "panel_loginCard";
            this.panel_loginCard.Size = new System.Drawing.Size(470, 480);
            this.panel_loginCard.TabIndex = 11;
            // 
            // label_loginSubtitle
            // 
            this.label_loginSubtitle.AutoSize = true;
            this.label_loginSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_loginSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_loginSubtitle.Location = new System.Drawing.Point(40, 75);
            this.label_loginSubtitle.Name = "label_loginSubtitle";
            this.label_loginSubtitle.Size = new System.Drawing.Size(326, 17);
            this.label_loginSubtitle.TabIndex = 10;
            this.label_loginSubtitle.Text = "Wprowadź dane uwierzytelniające, aby przejść do panelu.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.label2.Location = new System.Drawing.Point(36, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logowanie do systemu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.textBox_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_login.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_login.ForeColor = System.Drawing.Color.White;
            this.textBox_login.Location = new System.Drawing.Point(43, 140);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(380, 27);
            this.textBox_login.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(40, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hasło";
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_password.ForeColor = System.Drawing.Color.White;
            this.textBox_password.Location = new System.Drawing.Point(43, 210);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(380, 27);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Segoe UI Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(43, 265);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(380, 42);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "Zaloguj się";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_nextform
            // 
            this.label_nextform.AutoSize = true;
            this.label_nextform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_nextform.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nextform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label_nextform.Location = new System.Drawing.Point(40, 325);
            this.label_nextform.Name = "label_nextform";
            this.label_nextform.Size = new System.Drawing.Size(225, 19);
            this.label_nextform.TabIndex = 7;
            this.label_nextform.Text = "Nie masz konta? Zarejestruj się tutaj!";
            this.label_nextform.Click += new System.EventHandler(this.label5_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(43, 422);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(120, 32);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "Zamknij program";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginForm
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(820, 480);
            this.Controls.Add(this.panel_loginCard);
            this.Controls.Add(this.panel_brand);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarsztatDB - Logowanie do systemu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_brand.ResumeLayout(false);
            this.panel_brand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_loginCard.ResumeLayout(false);
            this.panel_loginCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_brand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_brandSubtitle;
        private System.Windows.Forms.Label label_brandTagline;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_loginCard;
        private System.Windows.Forms.Label label_loginSubtitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_nextform;
        private System.Windows.Forms.Button button_close;
    }
}

