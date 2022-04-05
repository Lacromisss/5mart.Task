using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp37
{
    internal class Book
    {
      
       
        public Book()
        {
            _id++;
            No = _id;
        }
        public int No { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Genre Genre { get; set; }
        public double Price { get; set; }
        private static int _id;

    }
}