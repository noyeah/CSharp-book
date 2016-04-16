using System;

namespace _2016_04_17_test_while_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,num =0;
            while(true)
            {
                num++;
                if (num == 100) // if num to be 100 continue -> sum +=101 and while end
                {
                    break;
                }
                if (num % 2 == 0)
                {
                    continue; 
                }
                sum += num;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
