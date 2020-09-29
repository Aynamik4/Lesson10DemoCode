using System;
using static System.Console;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fact f = new Fact(300, "Micke Engström", 150, "OOP Programmering");
            WriteLine($"{f.Pages} pages, written by {f.Author} about {f.Subject}, and the price is {f.Price}");
        }
    }
}
