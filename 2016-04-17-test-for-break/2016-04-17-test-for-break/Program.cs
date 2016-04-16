using System;

namespace _2016_04_17_test_for_break
{
    class Program
    {
        static void Main(string[] args)
        {
                int i = 2;

                while (true)
                {
                    int j = 1;

                    while (true)
                    {
                        Console.WriteLine(i + " * " + j + " = " + (i * j));

                        if (++j > 9) // ++j is biger than 9 is true
                        {
                            break;
                        }
                    }

                    if (++i > 9)
                    {
                        break;
                    }
                }

            int a = 9;
            string txt = (++a > 9)? "true" : "false";
            Console.WriteLine(txt);
            Console.ReadKey();
        }
    }
}
