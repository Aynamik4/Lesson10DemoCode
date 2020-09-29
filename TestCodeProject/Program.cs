using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace TestCodeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SubClass instance = new SubClass(58, "Håkan");
        }
    }

    class BaseClass
    {
        public string StringValue { get; set; }

        public BaseClass(string stringValue)
        {
            StringValue = stringValue;
        }

        //public BaseClass()
        //{
        //    StringValue = "N/A";
        //}
    }

    class SubClass : BaseClass
    {
        public int IntValue { get; set; }

        public SubClass(int intValue, string stringValue) : base(stringValue)
        {
            IntValue = intValue;
        }
    }
}
