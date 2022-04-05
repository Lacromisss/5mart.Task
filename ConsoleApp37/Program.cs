using System;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.AuthorName = "Mustafa";
            book.Genre = Genre.Dram;
            book.Name = "Ders oxumaqdan bezif !";
            book.Price = 1000;
            Library library = new Library();
            library.book1.Add(book);

        }

    }
}
