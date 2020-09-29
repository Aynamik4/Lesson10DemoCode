using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Animal // Base class (parent)
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Djuret låter.");
        }
    }

    class Pig : Animal // Derived class (child)
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says: Oink oink!");
        }
    }
    class Dog : Animal // Derived class (child)
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: Bark bark!");
        }
    }
}
