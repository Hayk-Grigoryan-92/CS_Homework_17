using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 16)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("The student's age cannot be less than 16 years old.");
                }
            }
        }
        private int[] grade = new int[10];

        public int[] Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Invalid grade");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] > 0 && value[i] < 10)
                    {
                        grade[i] = value[i];
                    }
                    else
                    {
                        throw new Exception("Invalid grade");
                    }
                }

            }
        }

        public Student(int id, string name, string surname, int age, int[] grade)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Grade = grade;
        }


        public void AddGrade(int grade)
        {
            for (int i = 0; i < 10; i++)
            {
                if (Grade[i] != 0)
                {
                    Grade[i] = grade;
                }
            }
        }

        public double GetAverageGrade()
        {
            int count = 0;
            int average = 0;
            int sum = 0;
            for (int i = 0; i < Grade.Length; i++)
            {
                if (Grade[i] != 0)
                {
                    sum += Grade[i];
                    count++;
                }

            }
            average = sum / count;
            return average;
        }

       /// ?????????
        public void DisplayInfo()
        {
            string gradeStr = string.Join(", ", Grade);
            double average = GetAverageGrade();

            Console.Write($"{Name} {Surname} | {Age} | grade average: {average} | grades : {gradeStr}");
        }

    }
}
