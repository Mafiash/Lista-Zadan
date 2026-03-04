using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    //klasa przechowujaca dane uzytkownika
    public class User
    {
        public Guid Id;
        public string Imie;
        public string Login;
        public string Haslo;

        public User(Guid id,string imie,string login,string haslo)
        {
            Id = id;
            Imie = imie;
            Login = login;
            Haslo = haslo;
        }
    }
}
