using System;

namespace _2016_04_16_test_literal_char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1냠\'냠냠"); Console.WriteLine("----------------");
            Console.WriteLine("2냠\"냠냠"); Console.WriteLine("----------------");
            Console.WriteLine("3냠\0냠냠"); Console.WriteLine("----------------");
            Console.WriteLine("4냠\a냠냠"); Console.WriteLine("----------------");
            Console.WriteLine("5냠\b냠냠"); Console.WriteLine("----------------");
            Console.WriteLine("6냠\f냠냠"); Console.WriteLine("----------------");
            Console.WriteLine("7냠\n냠냠"); Console.WriteLine("----------------");
            Console.WriteLine("8냠\r냠냠"); Console.WriteLine("----------------");
            Console.WriteLine("9냠\t냠냠"); Console.WriteLine("----------------");
            Console.WriteLine("10냠\u2023냠냠"); Console.WriteLine("----------------");
            Console.WriteLine("11냠\x1111냠냠"); Console.WriteLine("----------------");
            Console.WriteLine("12냠\v냠냠"); Console.WriteLine("----------------");
            Console.ReadKey();

        }
    }
}
