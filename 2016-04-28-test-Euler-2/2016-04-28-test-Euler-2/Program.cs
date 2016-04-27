using System;

namespace _2016_04_28_test_Euler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2,c=0, sum = 2; // 세번째 수열부터 시작
            for (;;)
            {
                c = a + b;
                if (c > 4000000)
                    break;
                if (c % 2 == 0)
                {
                    sum += c;
                    Console.WriteLine("짝수 더해진 sum = " + sum);
                }
                Console.WriteLine(c);
                a = b + c;
                if (a > 4000000)
                    break;
                if (a % 2 == 0)
                { 
                    sum += a;
                    Console.WriteLine("짝수 더해진 sum = " + sum);
                }
                Console.WriteLine(a);
                b = a + c;
                if (b > 4000000)
                    break;
                if (b % 2 == 0)
                {
                    sum += b;
                    Console.WriteLine("짝수 더해진 sum = " + sum);
                }
                Console.WriteLine(b);
                
            }
            Console.WriteLine("400만 이하 짝수 = "+ sum);
            Console.ReadKey();
        }
    }
}
