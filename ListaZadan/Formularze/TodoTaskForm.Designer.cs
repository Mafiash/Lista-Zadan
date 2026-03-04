namespace ListaZadan.Formularze
{
    partial class TodoTaskForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Numer = new System.Windows.Forms.Label();
            this.tb_Nazwa = new System.Windows.Forms.TextBox();
            this.tb_Opis = new System.Windows.Forms.TextBox();
            this.btn_Zapisz = new System.Windows.Forms.Button();
            this.cb_CzyZakonczone = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer";
            this.label1.Click += new System.EventHandler(this.lbl_Numer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis";
            // 
            // lbl_Numer
            // 
            this.lbl_Numer.AutoSize = true;
            this.lbl_Numer.Location = new System.Drawing.Point(164, 46);
            this.lbl_Numer.Name = "lbl_Numer";
            this.lbl_Numer.Size = new System.Drawing.Size(35, 13);
            this.lbl_Numer.TabIndex = 3;
            this.lbl_Numer.Text = "label4";
            this.lbl_Numer.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_Nazwa
            // 
            this.tb_Nazwa.Location = new System.Drawing.Point(167, 89);
            this.tb_Nazwa.Name = "tb_Nazwa";
            this.tb_Nazwa.Size = new System.Drawing.Size(242, 20);
            this.tb_Nazwa.TabIndex = 4;
            this.tb_Nazwa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_Opis
            // 
            this.tb_Opis.Location = new System.Drawing.Point(167, 143);
            this.tb_Opis.Multiline = true;
            this.tb_Opis.Name = "tb_Opis";
            this.tb_Opis.Size = new System.Drawing.Size(372, 108);
            this.tb_Opis.TabIndex = 5;
            // 
            // btn_Zapisz
            // 
            this.btn_Zapisz.Location = new System.Drawing.Point(584, 92);
            this.btn_Zapisz.Name = "btn_Zapisz";
            this.btn_Zapisz.Size = new System.Drawing.Size(127, 159);
            this.btn_Zapisz.TabIndex = 6;
            this.btn_Zapisz.Text = "Zapisz";
            this.btn_Zapisz.UseVisualStyleBackColor = true;
            this.btn_Zapisz.Click += new System.EventHandler(this.btn_Zapisz_Click);
            // 
            // cb_CzyZakonczone
            // 
            this.cb_CzyZakonczone.AutoSize = true;
            this.cb_CzyZakonczone.Location = new System.Drawing.Point(459, 92);
            this.cb_CzyZakonczone.Name = "cb_CzyZakonczone";
            this.cb_CzyZakonczone.Size = new System.Drawing.Size(80, 17);
            this.cb_CzyZakonczone.TabIndex = 7;
            this.cb_CzyZakonczone.Text = "checkBox1";
            this.cb_CzyZakonczone.UseVisualStyleBackColor = true;
            // 
            // TodoTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 288);
            this.Controls.Add(this.cb_CzyZakonczone);
            this.Controls.Add(this.btn_Zapisz);
            this.Controls.Add(this.tb_Opis);
            this.Controls.Add(this.tb_Nazwa);
            this.Controls.Add(this.lbl_Numer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TodoTaskForm";
            this.Text = "TodoTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Numer;
        private System.Windows.Forms.TextBox tb_Nazwa;
        private System.Windows.Forms.TextBox tb_Opis;
        private System.Windows.Forms.Button btn_Zapisz;
        private System.Windows.Forms.CheckBox cb_CzyZakonczone;
    }
}