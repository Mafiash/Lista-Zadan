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
    public partial class LoginControl : UserControl
    {
        //zmienna na główny formularz
        private MainForm _mainForm;

        public LoginControl(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            Dock = DockStyle.Fill;

        }

        private void btn_Zaloguj_Click(object sender, EventArgs e)
        {
            //sprawdzamy czy login i haslo nie sa pouste
            if (string.IsNullOrWhiteSpace(tb_Login.Text) || string.IsNullOrWhiteSpace(tb_Haslo.Text))
            {
                lbl_WalidacjaLogowania.Visible = true;
                lbl_WalidacjaLogowania.Text = "Login i hasło jest wymagane!";
            }
            else
            {
                //jeśli login i hasło są podane
                //sprawdzamy czy taki użytkownik istnieje
                User uzytkownik = _mainForm._UserManager.WyszukajUzytkownika(tb_Login.Text, tb_Haslo.Text);
                if(uzytkownik==null)
                {
                    //jeśli null - to znaczy że nie znalazło pary
                    //pokazujemy błąd
                    lbl_WalidacjaLogowania.Visible = true;
                    lbl_WalidacjaLogowania.Text = "Nieprawidłowy login lub hasło";
                }
                else
                {
                    //jeśli istnieje, to przechodzimy do ekranu z zadaniami
                    //i przekazujemy który użytkownik jest zalogowany
                    _mainForm.PokazTaskControl(uzytkownik);
                }
            }
        }

        private void btn_ZalozKonto_Click(object sender, EventArgs e)
        {
            _mainForm.PokazRegisterControl();
        }
    }
}
