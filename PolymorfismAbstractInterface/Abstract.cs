using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class Animal
    {
        // Abstract method does not have a body.
        abstract public void AnimalSound();

        // Regular method
        public void Sleep()
        {
            Console.WriteLine("Zzzzz");
        }
    }

    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Grisen säger: Nöff nöff!");
        }
    }
}
