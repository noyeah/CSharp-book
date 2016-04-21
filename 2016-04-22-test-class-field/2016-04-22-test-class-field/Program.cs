using System;

namespace _2016_04_22_test_class_field
{
    class Book
    {
        public int id;
        public char ch = '5';
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.id = 1;
            char ch1 = book.ch;
            Console.WriteLine(book.id);
            Console.WriteLine(ch1);
            Console.ReadKey();
            
        }
    }
}
