using System;

namespace _2016_04_17_test_class_method
{
    class Mathmatics
    {
        public int GetAreaOfSquare(int x)
        {
            return x * x;
        }

        public int GetValue()
        {
            return 10;
        }

        public void Output(string prefix, int value)
        {
            Console.WriteLine(prefix + value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathmatics m = new Mathmatics();
            int result = m.GetAreaOfSquare(m.GetValue());

            m.Output("결과 : ", result);
            Console.ReadKey();
        }
    }
}
