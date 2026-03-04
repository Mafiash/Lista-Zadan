using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    public class TodoTaskManager
    {
        //lista zadań
        private List<TodoTask> _WszystkieZadania;
        

        //konstruktor
        public TodoTaskManager()
        {
            //tworzymy pustą listę zadań
            _WszystkieZadania = new List<TodoTask>();
        }
        //metoda zwracająca zadanie po id
        public TodoTask ZnajdzZadanie(int id)
        {
            foreach(TodoTask zadanie in _WszystkieZadania)
            {
                if (zadanie.Id == id)
                    return zadanie;
            }
            return null;
        }

        //metoda dodająca zadanie do listy
        public void DodajZadanie(TodoTask zadanie)
        {
             _WszystkieZadania.Add(zadanie);

        }
        //metoda usuwająca zadanie z listy

        public void UsunZadanie(int taskID)
        {
            TodoTask zadanie = ZnajdzZadanie(taskID);
            _WszystkieZadania.Remove(zadanie);
        }

        //metoda zwracająca wszystkie zadania zalogowanego użytkownika
        public List<TodoTask> PobierzZadania(Guid idZalogowanego)
        {
            List<TodoTask> ZadaniaZalogowanegoi = new List<TodoTask>();
            foreach(TodoTask zadanie in _WszystkieZadania)
            {
                if (zadanie.UserId == idZalogowanego)
                    ZadaniaZalogowanegoi.Add(zadanie);
            }
            return ZadaniaZalogowanegoi;
        }

        //metoda obliczająca id dla następnego zadania

        public int ObliczNastepneId()
        {
            int max = 0;

            foreach(var zadanie in _WszystkieZadania)
            {
                if (zadanie.Id > max)
                    max = zadanie.Id;
            }
            return max + 1;
        }
    }
}
