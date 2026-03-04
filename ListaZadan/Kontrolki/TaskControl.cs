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
using ListaZadan.Formularze;

namespace ListaZadan.Kontrolki
{
    public partial class TaskControl : UserControl
    {
        //zmienna na główny formularz
        private MainForm _mainForm;
        //zmienna na zalogowanego uzytkownika
        private User _zalogowany;
        //zmienna na managera zadań
        private TodoTaskManager _TodoTaskManager;
        public TaskControl(MainForm mainForm,User user)
        {
            InitializeComponent();
            _mainForm = mainForm;
            Dock = DockStyle.Fill;

            _zalogowany = user;
            lbl_ZalogowanyWartosc.Text = _zalogowany.Imie;

            //tworzymy obiekt managera zadań
            _TodoTaskManager = new TodoTaskManager();

            //wyswietlamy kazde zadanie na liscie
            foreach(TodoTask zadanie in _TodoTaskManager.PobierzZadania(_zalogowany.Id))
            {
                DodajZadanieDoListy(zadanie);
            }

        }

        private void DodajZadanieDoListy(TodoTask zadanie)
        {
            ListViewItem item = new ListViewItem(zadanie.Id.ToString());
            item.SubItems.Add(zadanie.Title);
            string ready = zadanie.IsFinished ? "✓" : "✕";
            item.SubItems.Add(ready);

            listView1.Items.Add(item);
        }

        private void btn_Wyloguj_Click(object sender, EventArgs e)
        {
            _mainForm.PokazLoginControl();
        }

        private void btn_Dodaj_Click(object sender, EventArgs e)
        {
            int id = _TodoTaskManager.ObliczNastepneId();
            TodoTask noweZadanie = new TodoTask(id, _zalogowany.Id, "", "");

            //tworzymy formularz
            TodoTaskForm todotaskform = new TodoTaskForm(noweZadanie);
            //wyswietlamy formularz
            todotaskform.ShowDialog();

            //po zamknieciu formaularza bedziemy sprawdzali czy to zostało zapisane
            if(todotaskform.CzyZapisano)
            {
                _TodoTaskManager.DodajZadanie(noweZadanie);
                DodajZadanieDoListy(noweZadanie);
            }
        }

        private void btn_Edytuj_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Nazleży najpierw zaznaczyć zadanie.", "Infromacja", MessageBoxButtons.OK);
            }
            else
            {
                string taskID = listView1.SelectedItems[0].SubItems[0].Text;
                TodoTask zadanie = _TodoTaskManager.ZnajdzZadanie(int.Parse(taskID));

                TodoTaskForm task = new TodoTaskForm(zadanie);
                task.ShowDialog();

                if(task.CzyZapisano)
                {
                    listView1.SelectedItems[0].SubItems[1].Text = zadanie.Title;
                    listView1.SelectedItems[0].SubItems[2].Text = zadanie.IsFinished ? "✓" : "✕";
                }
            }
        }

        private void btn_Usun_Click(object sender, EventArgs e)
        {
            //sprawdzamy czy jest zaznaczone zadanie na liście
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano zadania do skasowania.", "Informacja", MessageBoxButtons.OK);
            }
            else
            {
                string zaznaczoneZadanie = listView1.SelectedItems[0].SubItems[0].Text;
                _TodoTaskManager.UsunZadanie(int.Parse(zaznaczoneZadanie));
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
    }
}
