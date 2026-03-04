using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    public class TodoTask
    {
        public int Id;
        public Guid UserId;
        public string Title;
        public string Description;
        public bool IsFinished;

        public TodoTask(int number,Guid userId,string title,string description)
        {
            Id = number;
            UserId = userId;
            Title = title;
            Description = description;
            IsFinished = false;
        }
    }
}
