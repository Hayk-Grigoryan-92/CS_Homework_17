using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    internal class Library
    {
        public Book[] books { get; set; }
        int count = 0;


        public void AddBook(Book book)
        {
            books[count++] = book;
        }

        public void DisplayBooks()
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                {
                    Console.Write($"{books[i].Author} | {books[i].Tittle} | {books[i].Isbn} : {books[i].IsBorrowed} \n");
                }
            }
        }

        public void BorrowBookByISBN(string isbn)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Isbn == isbn)
                {
                    books[i].IsBorrowed = true;
                    Console.Write($"You have successfully borrowed | {books[i].Author} | {books[i].Tittle} | {books[i].IsBorrowed}");
                }
            }
        }

        public void ReturnBookByISBN(string isbn)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Isbn == isbn)
                {
                    books[i].IsBorrowed = false;
                    Console.Write($"You have successfully returned | {books[i].Author} | {books[i].Tittle} | {books[i].IsBorrowed}");
                }
            }
        }

        public Library(int size)
        {
            books = new Book[size];
        }

    }
}
