using ListaZadan.Klasy;
using ListaZadan.Kontrolki;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaZadan
{
    public partial class MainForm : Form
    {
        public UserManager _UserManager;
        public MainForm()
        {
            InitializeComponent();
            _UserManager = new UserManager();
            //przy uruchomieniu aplikacji pokazujemy panel logowania
            PokazLoginControl();
        }

        //metoda wyswietlajaca ekran logowania
        public void PokazLoginControl()
        {
            //czyscimy kontrolki
            Controls.Clear();
            //tworzymy nowy obiekt logowania
            Controls.Add(new LoginControl(this));
        }

        //metoda wyswietlajaca ekran rejestracji
        public void PokazRegisterControl()
        {
            //czyscimy kontrolki
            Controls.Clear();
            //tworzymy nowy obiekt logowania
            Controls.Add(new RegisterControl(this));
        }

        //metoda wyswietlajaca ekran listy zadan
        public void PokazTaskControl(User user)
        {
            //czyscimy kontrolki
            Controls.Clear();
            //tworzymy nowy obiekt logowania
            Controls.Add(new TaskControl(this,user));
        }
    }
}
