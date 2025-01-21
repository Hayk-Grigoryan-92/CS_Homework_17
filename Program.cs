using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Library lib = new Library(100);
            //Book book1 = new Book("asasa", "sssss", "asa5s45as");
            //Book book2 = new Book("zzzz", "zzzzzz", "hhg8s45as");
            //Book book3 = new Book("ccccc", "cccccc", "cvcv5s45as");
            //Book book4 = new Book("bbbbb", "bbbb", "bbb5s45as");
            //Book book5 = new Book("kkkk", "kkkkk", "kkk5s45as");

            //lib.AddBook(book1);
            //lib.AddBook(book2);
            //lib.AddBook(book3);
            //lib.AddBook(book4);
            //lib.AddBook(book5);
            //book1.IsBorrowed = true;
            //book3.IsBorrowed= true;
            //lib.DisplayBooks();


            //------------------------------------------------------

            Student student1 = new Student(1, "Aram", "Sargsyan", 18,  new int[] {2,4,7,8});
            student1.AddGrade(5);
            student1.AddGrade(6);
            student1.GetAverageGrade();
            student1.DisplayInfo();

            School school = new School(100);
            school.AddStudent(student1);
            school.Displaytudents();
            
        }
    }
}
