using System;

namespace _2016_04_27_test_foreach_f
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] A = new int[] { 80, 90, 90, 50, 100 };

            foreach(int num in A)
            {
                sum += num;
            }
            // sum = A학생의 성적의 합
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
