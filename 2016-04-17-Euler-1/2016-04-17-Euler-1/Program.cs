using System;

namespace _2016_04_17_Euler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, sum=0;
            while (++num < 1000)
            {
                if (num % 3 == 0 || num % 5 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
