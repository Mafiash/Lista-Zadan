using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    //klasa w ktorej zarzadzamy uzytkownikami w aplikacji
    public class UserManager
    {
        //lista uzytkownikow w aplikacji
        //prywatna - chcemy by tylko w tej klasie mozna byla ja modyfikowac
        private List<User> _users;

        public UserManager()
        {
            //utworzenia pustej listy
            _users = new List<User>();

            _users.Add(new User(Guid.NewGuid(), "test", "test", "test"));
        }

        //metoda wyszukujaca uzytkownika
        public User WyszukajUzytkownika(string login,string haslo)
        {
            //literujemu po userach
            foreach(User user in _users)
            {
                //jezeli uzytkownik z listy ma takie same haslo i login
                if(user.Login==login && user.Haslo==haslo)
                {
                    //jesli tak to zwracamy usera
                    return user;
                }
            }
            return null;
        }
        //metoda sprawdzajaca czy podany login jest wolny
        public bool CzyLoginWolny(string login)
        {
            foreach (User user in _users)
            {
                //jesli user z listy ma podany login
                if (user.Login == login)
                {
                    //to zwracamy falsz
                    return false;
                }

            }
            //jesli nie ma takiego usera zawracamy nazwe
            return true;
        }


        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }

    
}
