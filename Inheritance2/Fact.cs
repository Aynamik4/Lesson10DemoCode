using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2
{
    class Fact : Book
    {
        public string Subject;

        public Fact(int pages, string author, int price, string subject) : base(pages, author, price)
        {
            Subject = subject;
        }
    }
}
