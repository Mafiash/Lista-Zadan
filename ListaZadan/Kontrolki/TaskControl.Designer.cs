namespace ListaZadan.Kontrolki
{
    partial class TaskControl
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
            this.lbl_Zalogowany = new System.Windows.Forms.Label();
            this.lbl_ZalogowanyWartosc = new System.Windows.Forms.Label();
            this.btn_Wyloguj = new System.Windows.Forms.Button();
            this.btn_Dodaj = new System.Windows.Forms.Button();
            this.btn_Edytuj = new System.Windows.Forms.Button();
            this.btn_Usun = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Tytul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Zrobione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "TO DO";
            // 
            // lbl_Zalogowany
            // 
            this.lbl_Zalogowany.AutoSize = true;
            this.lbl_Zalogowany.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Zalogowany.Location = new System.Drawing.Point(44, 72);
            this.lbl_Zalogowany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Zalogowany.Name = "lbl_Zalogowany";
            this.lbl_Zalogowany.Size = new System.Drawing.Size(151, 22);
            this.lbl_Zalogowany.TabIndex = 1;
            this.lbl_Zalogowany.Text = "Zalogowany jako:";
            // 
            // lbl_ZalogowanyWartosc
            // 
            this.lbl_ZalogowanyWartosc.AutoSize = true;
            this.lbl_ZalogowanyWartosc.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_ZalogowanyWartosc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_ZalogowanyWartosc.Location = new System.Drawing.Point(187, 72);
            this.lbl_ZalogowanyWartosc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ZalogowanyWartosc.Name = "lbl_ZalogowanyWartosc";
            this.lbl_ZalogowanyWartosc.Size = new System.Drawing.Size(71, 22);
            this.lbl_ZalogowanyWartosc.TabIndex = 2;
            this.lbl_ZalogowanyWartosc.Text = "Anonim";
            // 
            // btn_Wyloguj
            // 
            this.btn_Wyloguj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Wyloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Wyloguj.Location = new System.Drawing.Point(307, 15);
            this.btn_Wyloguj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Wyloguj.Name = "btn_Wyloguj";
            this.btn_Wyloguj.Size = new System.Drawing.Size(60, 65);
            this.btn_Wyloguj.TabIndex = 3;
            this.btn_Wyloguj.Text = "🚪";
            this.btn_Wyloguj.UseVisualStyleBackColor = false;
            this.btn_Wyloguj.Click += new System.EventHandler(this.btn_Wyloguj_Click);
            // 
            // btn_Dodaj
            // 
            this.btn_Dodaj.BackColor = System.Drawing.Color.Lime;
            this.btn_Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Dodaj.Location = new System.Drawing.Point(307, 102);
            this.btn_Dodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Dodaj.Name = "btn_Dodaj";
            this.btn_Dodaj.Size = new System.Drawing.Size(60, 132);
            this.btn_Dodaj.TabIndex = 4;
            this.btn_Dodaj.Text = "+";
            this.btn_Dodaj.UseVisualStyleBackColor = false;
            this.btn_Dodaj.Click += new System.EventHandler(this.btn_Dodaj_Click);
            // 
            // btn_Edytuj
            // 
            this.btn_Edytuj.BackColor = System.Drawing.Color.Blue;
            this.btn_Edytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Edytuj.Location = new System.Drawing.Point(307, 236);
            this.btn_Edytuj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Edytuj.Name = "btn_Edytuj";
            this.btn_Edytuj.Size = new System.Drawing.Size(60, 132);
            this.btn_Edytuj.TabIndex = 5;
            this.btn_Edytuj.Text = "✎";
            this.btn_Edytuj.UseVisualStyleBackColor = false;
            this.btn_Edytuj.Click += new System.EventHandler(this.btn_Edytuj_Click);
            // 
            // btn_Usun
            // 
            this.btn_Usun.BackColor = System.Drawing.Color.Red;
            this.btn_Usun.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Usun.Location = new System.Drawing.Point(307, 374);
            this.btn_Usun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Usun.Name = "btn_Usun";
            this.btn_Usun.Size = new System.Drawing.Size(60, 132);
            this.btn_Usun.TabIndex = 6;
            this.btn_Usun.Text = "🗑";
            this.btn_Usun.UseVisualStyleBackColor = false;
            this.btn_Usun.Click += new System.EventHandler(this.btn_Usun_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_Tytul,
            this.col_Zrobione});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 102);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(286, 407);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            this.col_ID.Width = 50;
            // 
            // col_Tytul
            // 
            this.col_Tytul.Text = "Tytuł";
            this.col_Tytul.Width = 120;
            // 
            // col_Zrobione
            // 
            this.col_Zrobione.Text = "Zrobione";
            this.col_Zrobione.Width = 24674;
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_Usun);
            this.Controls.Add(this.btn_Edytuj);
            this.Controls.Add(this.btn_Dodaj);
            this.Controls.Add(this.btn_Wyloguj);
            this.Controls.Add(this.lbl_ZalogowanyWartosc);
            this.Controls.Add(this.lbl_Zalogowany);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(375, 520);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Zalogowany;
        private System.Windows.Forms.Label lbl_ZalogowanyWartosc;
        private System.Windows.Forms.Button btn_Wyloguj;
        private System.Windows.Forms.Button btn_Dodaj;
        private System.Windows.Forms.Button btn_Edytuj;
        private System.Windows.Forms.Button btn_Usun;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_Tytul;
        private System.Windows.Forms.ColumnHeader col_Zrobione;
    }
}
