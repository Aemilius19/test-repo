using System.ComponentModel.DataAnnotations;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("1988",12);
            Book book1 = new Book("neyse", 10);
            Book book2 = new Book("felafel", 8.3);

            Library kitabxana = new Library();
            kitabxana.AddBook(book1);
            kitabxana.AddBook(book2);
            kitabxana.AddBook(book);

            kitabxana.ShowAllBooks();

        }
    }

}