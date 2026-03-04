using ListaZadan.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaZadan.Formularze
{
    public partial class TodoTaskForm : Form
    {
        public TodoTask _TodoTask;
        public bool CzyZapisano;
        public TodoTaskForm(TodoTask zadanie)
        {
            InitializeComponent();
            _TodoTask = zadanie;
            lbl_Numer.Text = zadanie.Id.ToString();
            tb_Nazwa.Text = zadanie.Title;
            tb_Opis.Text = zadanie.Description;
            cb_CzyZakonczone.Checked = zadanie.IsFinished;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Numer_Click(object sender, EventArgs e)
        {

        }

        private void btn_Zapisz_Click(object sender, EventArgs e)
        {
            _TodoTask.Description = tb_Opis.Text;
            _TodoTask.Title = tb_Nazwa.Text;
            _TodoTask.IsFinished = cb_CzyZakonczone.Checked;
            CzyZapisano = true;
            Close();
        }
    }
}

