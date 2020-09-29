using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2
{
    class Book
    {
        public int Pages;
        public string Author;
        public int Price;

        public Book(int pages, string author, int price)
        {
            Pages = pages;
            Author = author;
            Price = price * 2;
        }
    }
}
