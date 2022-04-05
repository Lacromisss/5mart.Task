using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp37
{
    internal class Library
    {
        public Book FİndBookByNo(int? no)
        {
            if (no == null)
                throw new Exception("xetaaaaa");
            Book searchBook = book1.Find(book => book.No == no);
            if (searchBook == null)
            {
                return null;
            }
            else
            {
                return searchBook;
            }
        }
        public List<Book> book1 = new List<Book>();
        public List<Book> FilterByPrice(double min, double max)
        {
            List<Book> newBooks = book1.FindAll(book => book.Price > min && book.Price < max);
            return newBooks;
        }
        public List<Book> FilterByGenre(Genre genre)
        {
            List<Book> newBooks = book1.FindAll(book => book.Genre == genre);
            return newBooks;
        }
       
    }
}