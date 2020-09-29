﻿using System;

namespace PolymorfismAbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Standard
            Console.WriteLine("Standard");
            Standard.Animal myAnimal = new Standard.Animal();
            Standard.Animal myPig = new Standard.Pig();
            Standard.Animal myDog = new Standard.Dog();

            myAnimal.AnimalSound();
            myPig.AnimalSound();
            myDog.AnimalSound();

            Console.WriteLine("---------------------------------------------");

            // Polymorphism
            Console.WriteLine("Polymorphism");
            Polymorphism.Animal myAnimal2 = new Polymorphism.Animal();
            Polymorphism.Animal myPig2 = new Polymorphism.Pig();
            Polymorphism.Animal myDog2 = new Polymorphism.Dog();

            myAnimal2.AnimalSound();
            myPig2.AnimalSound();
            myDog2.AnimalSound();

            Console.WriteLine("---------------------------------------------");

            // Abstract
            Console.WriteLine("Abstract");
            // Abstract.Animal animal = new Abstract.Animal(); // Won't compile!

            Abstract.Animal animal = new Abstract.Pig();
            animal.AnimalSound();
            animal.Sleep();

            Console.WriteLine("---------------------------------------------");

            // Interface
            Console.WriteLine("Interface");
            InterfaceExample.Pig pig = new InterfaceExample.Pig();
            pig.AnimalSound();

            Console.WriteLine("---------------------------------------------");

            // Multiple interfaces
            Console.WriteLine("Multiple interfaces");

            InterfaceExample.DemoClass demo = new InterfaceExample.DemoClass();
            demo.MyMethod();
            demo.MyOtherMethod();
        }
    }
}
