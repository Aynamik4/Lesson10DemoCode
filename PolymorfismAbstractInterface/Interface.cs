using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    interface IAnimal
    {
        void AnimalSound();
    }

    class Pig : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Grisen säger Nöff nöff");
        }
    }

    // Implement multiple interfaces.
    interface IFirstInterface
    {
        void MyMethod();
    }

    interface ISecondInterface
    {
        void MyOtherMethod();
    }

    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("Inside MyMethod");
        }

        public void MyOtherMethod()
        {
            Console.WriteLine("Inside MyOtherMethod");
        }
    }
}
