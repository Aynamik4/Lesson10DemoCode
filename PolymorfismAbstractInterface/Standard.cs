using System;
using System.Collections.Generic;
using System.Text;

namespace Standard
{
    class Animal // Base class (parent)
    {
        public void AnimalSound()
        {
            Console.WriteLine("Djuret låter.");
        }
    }

    class Pig : Animal // Derived class (child)
    {
        new public void AnimalSound()
        {
            Console.WriteLine("The pig says: Oink oink!");
        }
    }
    class Dog : Animal // Derived class (child)
    {
        new public void AnimalSound()
        {
            Console.WriteLine("The dog says: Bark bark!");
        }
    }
}
