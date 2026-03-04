namespace ListaZadan.Kontrolki
{
    partial class LoginControl
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_haslo = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Haslo = new System.Windows.Forms.TextBox();
            this.lbl_WalidacjaLogowania = new System.Windows.Forms.Label();
            this.btn_Zaloguj = new System.Windows.Forms.Button();
            this.btn_ZalozKonto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(79, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista zadań";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Login.Location = new System.Drawing.Point(70, 136);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(62, 22);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Login:";
            // 
            // lbl_haslo
            // 
            this.lbl_haslo.AutoSize = true;
            this.lbl_haslo.Font = new System.Drawing.Font("Monotype Corsiva", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_haslo.Location = new System.Drawing.Point(70, 182);
            this.lbl_haslo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_haslo.Name = "lbl_haslo";
            this.lbl_haslo.Size = new System.Drawing.Size(59, 21);
            this.lbl_haslo.TabIndex = 2;
            this.lbl_haslo.Text = "Hasło:";
            // 
            // tb_Login
            // 
            this.tb_Login.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_Login.Location = new System.Drawing.Point(149, 135);
            this.tb_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(124, 26);
            this.tb_Login.TabIndex = 3;
            // 
            // tb_Haslo
            // 
            this.tb_Haslo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_Haslo.Location = new System.Drawing.Point(149, 180);
            this.tb_Haslo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Haslo.Name = "tb_Haslo";
            this.tb_Haslo.PasswordChar = '*';
            this.tb_Haslo.Size = new System.Drawing.Size(124, 26);
            this.tb_Haslo.TabIndex = 4;
            // 
            // lbl_WalidacjaLogowania
            // 
            this.lbl_WalidacjaLogowania.AutoSize = true;
            this.lbl_WalidacjaLogowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WalidacjaLogowania.ForeColor = System.Drawing.Color.Red;
            this.lbl_WalidacjaLogowania.Location = new System.Drawing.Point(71, 225);
            this.lbl_WalidacjaLogowania.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_WalidacjaLogowania.Name = "lbl_WalidacjaLogowania";
            this.lbl_WalidacjaLogowania.Size = new System.Drawing.Size(230, 18);
            this.lbl_WalidacjaLogowania.TabIndex = 5;
            this.lbl_WalidacjaLogowania.Text = "Nieprawidłowy login lub hasło";
            // 
            // btn_Zaloguj
            // 
            this.btn_Zaloguj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Zaloguj.Location = new System.Drawing.Point(121, 284);
            this.btn_Zaloguj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Zaloguj.Name = "btn_Zaloguj";
            this.btn_Zaloguj.Size = new System.Drawing.Size(139, 60);
            this.btn_Zaloguj.TabIndex = 6;
            this.btn_Zaloguj.Text = "Zaloguj";
            this.btn_Zaloguj.UseVisualStyleBackColor = false;
            this.btn_Zaloguj.Click += new System.EventHandler(this.btn_Zaloguj_Click);
            // 
            // btn_ZalozKonto
            // 
            this.btn_ZalozKonto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_ZalozKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ZalozKonto.Location = new System.Drawing.Point(121, 365);
            this.btn_ZalozKonto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ZalozKonto.Name = "btn_ZalozKonto";
            this.btn_ZalozKonto.Size = new System.Drawing.Size(139, 60);
            this.btn_ZalozKonto.TabIndex = 7;
            this.btn_ZalozKonto.Text = "Załóż konto";
            this.btn_ZalozKonto.UseVisualStyleBackColor = false;
            this.btn_ZalozKonto.Click += new System.EventHandler(this.btn_ZalozKonto_Click);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.Controls.Add(this.btn_ZalozKonto);
            this.Controls.Add(this.btn_Zaloguj);
            this.Controls.Add(this.lbl_WalidacjaLogowania);
            this.Controls.Add(this.tb_Haslo);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.lbl_haslo);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(375, 520);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_haslo;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Haslo;
        private System.Windows.Forms.Label lbl_WalidacjaLogowania;
        private System.Windows.Forms.Button btn_Zaloguj;
        private System.Windows.Forms.Button btn_ZalozKonto;
    }
}
