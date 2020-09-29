using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //IActivity activity = new Car();
            //activity.MainActivity();

            //List<int> wholeNumbers = new List<int>() { 58, 14, 44, 10 };
            //IntComparer comparer = new IntComparer();
            //wholeNumbers.Sort(comparer);

            //foreach (int number in wholeNumbers)
            //{
            //    Console.Write($"{number} ");
            //}

            List<Car> cars = new List<Car>()
            {
                new Car() { TopSpeed = 110 },
                new Car() { TopSpeed = 90},
                new Car() { TopSpeed = 80}
            };

            Car car1 = new Car();
            cars.Sort(car1);

            foreach (Car car in cars)
            {
                Console.WriteLine(car.TopSpeed);
            }
        }
    }

    class IntComparer : IComparer<int>
    {
        public int Compare([AllowNull] int x, [AllowNull] int y)
        {
            if (x < y)
                return 1;
            else
                if (x > y)
                return -1;
            else
                return 0;
        }
    }

    interface IActivity
    {
        void MainActivity();
    }

    class Dog : IActivity
    {
        public void MainActivity()
        {
            Console.WriteLine("Barking and eating all day long");
        }
    }

    class Car : IActivity, IComparer<Car>
    {
        public int TopSpeed { get; set; }

        public int Compare([AllowNull] Car x, [AllowNull] Car y)
        {
            if (x.TopSpeed > y.TopSpeed)
                return -1;
            else
                if (x.TopSpeed < y.TopSpeed)
                return 1;
            else
                return 0;
        }

        public void MainActivity()
        {
            Console.WriteLine("Driving and honking the horn!");
        }
    }
}
