using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListaZadan.Klasy;

namespace ListaZadan.Kontrolki
{
    public partial class RegisterControl : UserControl
    {
        //zmienna na główny formularz
        private MainForm _mainForm;

        public RegisterControl(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            Dock = DockStyle.Fill;

        }

        private void btn_Cofnij_Click(object sender, EventArgs e)
        {
            _mainForm.PokazLoginControl();
        }

        private void btn_Zarejestruj_Click(object sender, EventArgs e)
        {
            if(_mainForm._UserManager.CzyLoginWolny(tb_Login.Text))
            {
                User newUser = new User(Guid.NewGuid(), tb_Imie.Text, tb_Login.Text, tb_Haslo.Text);

                _mainForm._UserManager.AddUser(newUser);

                _mainForm.PokazTaskControl(newUser);
            }

           
        }
    }
}
