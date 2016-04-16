using System;

namespace _2016_04_17_test_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = (char)Console.Read();
            switch (ch)
            {
                case '9': // If you press the 9 output is case '1' wow!
                case '1':
                    Console.WriteLine("one");
                    break;
                default:
                    Console.WriteLine("cwtt rolll");
                    break;
             }
            Console.ReadKey();
        }
    }
}
