using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Library
    {
        string name;
        Book[] books;
        public Library(string name, Book[] books)
        {
            this.name = name;
            books = new Book[0];
        }
        public Library()
        {
            this.name = name;
            books = new Book[0];
        }
        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }
        public void SearchBook(string name)
        {
            foreach (var book in books)
            {
                if (book.name == name)
                {
                    Console.WriteLine($"{book}");
                }
                else
                {
                    Console.WriteLine("tapilmadi");
                }
            }
        }
        public void ShowAllBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"book name:{book.name} book price:{book.Price}");
            }
        }

    }
}
