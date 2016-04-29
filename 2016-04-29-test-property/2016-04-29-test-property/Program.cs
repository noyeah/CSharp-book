using System;

namespace _2016_04_29_test_property
{
    class Circle
    {
        public Circle()
        {
            Console.WriteLine("객체 생성");
        }
        double pi = 3.14;

        public double Pi
        {
            get { return pi; }
            set
            {
                if (value >= 3 && value <= 3.15)
                {
                    pi = value;
                }
                else
                {
                    Console.WriteLine("잘못된값 입력! " + value);
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle o = new Circle();
            Console.WriteLine(o.Pi);
            o.Pi = 3.14159;
            Console.WriteLine(o.Pi);
            double piValue = o.Pi;
            Console.WriteLine("piValue = " + piValue);
            o.Pi = 3.16;
            Console.ReadKey();
        }
    }
}
