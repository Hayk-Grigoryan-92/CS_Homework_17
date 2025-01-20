using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    internal class Book
    {
        public string Tittle { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(string tittle, string author, string isbn, bool isBorrowed = false)
        {
            Tittle = tittle;
            Author = author;
            Isbn = isbn;
            IsBorrowed = isBorrowed;
        }

        public bool BorrowBook(string tittle, string author, bool isBorrowed)
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"The book |{Author} {Tittle} | is already borrowed.");
                return isBorrowed;
            }

            IsBorrowed = true;
            Console.WriteLine($"You have successfully borrowed | {Author} {Tittle} |.");
            return isBorrowed;
        }

        public bool ReturnBook(string tittle, bool isBorrowed)
        {
            IsBorrowed = false;
            Console.WriteLine($"You have successfully returned | {Tittle} | book.");
            return isBorrowed;
        }

    }
}
