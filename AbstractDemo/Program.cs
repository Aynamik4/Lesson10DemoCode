using System;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Eat();
        }
    }

    //abstract class Animal
    //{
    //    public int Age { get; set; }

    //    abstract public void Eat();
    //}

    class Animal
    {
        public int Weight { get; set; }
    }


    class Cat : Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating sea food!");
        }
    }

    class HouseCat : Cat
    {
        public override void Eat()
        {
            Console.WriteLine("Eating mice...");
        }
    }
}
