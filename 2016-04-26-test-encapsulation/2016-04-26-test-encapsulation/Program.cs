using System;

namespace _2016_04_26_test_encapsulation
{
    class Circle
    {
        private double Pi = 3.14;

        private double GetArea(double radius)
        {
            return radius * radius * Pi;
        }

        public void Print(double value)
        {
            Console.WriteLine(GetArea(value));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle one = new Circle();

            one.Print(10);
            Console.ReadKey();
        }
    }
}
