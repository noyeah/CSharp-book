using System;

namespace _2016_04_17_test_ternary_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            string result = (num % 2 == 0) ? "짝수" : "홀수";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
