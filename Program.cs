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

            //Student student1 = new Student(1, "Aram", "Sargsyan", 18,  new int[] {2,4,7,8});
            //student1.AddGrade(5);
            //student1.AddGrade(6);
            //student1.GetAverageGrade();
            //student1.DisplayInfo();

            //School school = new School(100);
            //school.AddStudent(student1);
            //school.Displaytudents();

            //--------------------------------------------------------------

            //Product product1 = new Product("shirt", "Clothes", 5000, 2);
            //Product product2 = new Product("cross", "Shoes", 33000, 1);
            //product1.UpdateQuantity(4);
            ////product1.DisplayInfo();

            //Inventory invent = new Inventory(10);

            //invent.AddProduct(product1);
            //invent.AddProduct(product2);
            //Console.WriteLine("Before Update:");          
            //invent.DisplayProducts();
            //string id = Console.ReadLine();
            //invent.UpdateProductQuantity(4, id);
            //Console.WriteLine("After Update:");
            //invent.DisplayProducts();

            //string findId = Console.ReadLine();
            //invent.FindProductByID(findId);

            //-------------------------------------------------------------------------

            BankAccount account1 = new BankAccount("Aram Aramyan", 16600144565444);
            BankAccount account2 = new BankAccount("Lilit Minasyan", 16600555666);
            account1.Deposit(15000);
            account1.Withdraw(3000);
            //account1.DisplayInfo();
            account2.Deposit(34000);

            Bank aeb = new Bank(100);
            aeb.AddAccount(account1);
            aeb.AddAccount(account2);
            

            aeb.DepositToAccount(2000, 16600144565444);
            aeb.WithdrawFromAccount(8000, 16600144565444);
            //aeb.FindAccountByNumber(16600144565444);
            aeb.DisplayAccounts();


        }
    }
}
