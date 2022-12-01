using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB102_Console_App.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        private static int _id;

        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
            _id++;
            Id = _id;
        }


    }
}
