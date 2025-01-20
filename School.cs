using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    internal class School
    {
        public Student[] school {  get; set; }
        private int count = 0;

        public void AddStudent(Student student)
        {
            school[count++] = student;
        }

        public void Displaytudents()
        {
            for (int i = 0; i < school.Length; i++)
            {
                if (school[i] != null)
                {
                    Console.WriteLine(school[i]);
                }
            }
        }

        public Student FindStudentByID(int id)
        {
            for (int i = 0; i < school.Length; i++)
            {
                if (school[i].Id == id)
                {
                   return school[i];
                }
            }
            throw new Exception("You entered wrong ID");
        }

        public School(int size)
        {
            school = new Student[size];
        }

    }
}
