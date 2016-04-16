using System;

namespace _2016_04_17_test_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            foreach(int num in arr)
            {
                Console.WriteLine(num); // Foreach is arr array[0-end] in num and cwtt 
            }

            Console.ReadKey();
        }
    }
}
