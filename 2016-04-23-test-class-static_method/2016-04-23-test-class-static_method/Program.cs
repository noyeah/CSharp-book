using System;

namespace _2016_04_23_test_class_static_method
{
    class Book
    {
        static public int Count;
        public string Title;

        public Book(string title)
        {
            Title = title;
        }

        public void Open()
        {
            Console.WriteLine("펼치다.");
            Count++;
        }

        static public void Confirm() // Static method 는 객체를 쓰지않아도 사용 가능!! 오히려 객체와 다른 메모리 상에 별도로 존재하기 때문에 객체를 사용하여 이 함수를 쓸수 없다!!!!
        {
            Console.WriteLine(Count + "번 펼쳐졌다.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("냠");
            book.Open();
            book.Open();
            book.Open();
            book.Open();
            book.Open();

            Book.Confirm(); // book 객체가 아닌 Book.Conform()으로 객체를 쓰지않고 Confirm() 함수를 사용했다 

            Console.ReadKey();
        }
    }
}
