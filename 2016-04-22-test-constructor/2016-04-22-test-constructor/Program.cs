using System;

namespace _2016_04_22_test_constructor
{
    class Book
    {
        static public int Count;

        public string Title;
        public decimal ISBN13;
        public string Author;
        public Book()
        {
            Console.WriteLine("생성자 생김 뿌ㅡ우");
        }

        public Book(string title)
        {
            Title = title;
            Count++;
            Console.WriteLine("객체 사용 횟수 = "+ Count);
        }

        public Book(string title, decimal isbn13)
        {
            Title = title;
            ISBN13 = isbn13;
            Count++;
            Console.WriteLine("객체 사용 횟수 = " + Count);
        }

        public Book(string title, decimal isbn13, string author)
        {
            Title = title;
            ISBN13 = isbn13;
            Author = author;
            Count++;
            Console.WriteLine("객체 사용 횟수 = " + Count);
        }

        public void Output()
        {
            Console.WriteLine(Title);
            Console.WriteLine(ISBN13);
            Console.WriteLine(Author);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Book a = new Book("a");
            a.Output();
            Console.WriteLine("-----------------");
            Book b = new Book("b",1111);
            b.Output();
            Console.WriteLine("-----------------");
            Book c = new Book("c",2222,"wwww");
            c.Output();
            Console.WriteLine("-----------------");
            Console.ReadKey();

        }
    }
}
