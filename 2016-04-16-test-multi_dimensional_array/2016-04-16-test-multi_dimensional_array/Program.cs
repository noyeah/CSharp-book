using System;

namespace _2016_04_16_test_multi_dimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] num = new int[2, 3, 10];
            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (n == 0)
                            num[n, i, j] = i * 10 + j;
                        else
                            num[n, i, j] = num[n - 1, i, j]+30; 
                        Console.Write("[{0},{1},{2}] " + num[n,i, j] +"\t",n, i, j);
                    }
                    Console.WriteLine('\n');
                }
                Console.WriteLine("--------------------------------------------------------------------\n");
            }
            Console.ReadKey();

        }
    }
}
