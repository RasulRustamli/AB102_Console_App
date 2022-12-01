using AB102_Console_App.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB102_Console_App.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Enums Type { get; set; }
        public  int StudentLimit { get; set; }
        Student[] students=new Student[0];

        public Classroom(string name,Enums type)
        {
            Name = name;
            Type = type;

            if (type==Enums.BackEnd)
            {
                
                StudentLimit = 20;
            }
            else
            {
                StudentLimit = 15;
            }

        }
        public void StudentAdd(Student student)
        {
            if (students.Length<StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
        }
    }
}
