using System;

namespace _2016_04_16_test_array_change
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[60];
            num[0] = 10;
            Console.WriteLine(num[0]);
            num = new int[120];
            Console.WriteLine(num[0]);
            Console.ReadKey();
        }
    }
}
