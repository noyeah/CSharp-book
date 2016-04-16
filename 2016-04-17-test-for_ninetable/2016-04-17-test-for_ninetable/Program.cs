using System;

namespace _2016_04_17_test_for_ninetable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (i*j));
                }
                Console.WriteLine("-------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
