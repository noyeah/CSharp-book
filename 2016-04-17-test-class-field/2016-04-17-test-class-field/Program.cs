using System;

namespace _2016_04_17_test_class_field
{
    class book
    {
        public string Title;
        public decimal ISBN13;
        public string Cointents;
        public string Author;
        public int PageCount;

        public void Open()
        {
            Console.WriteLine("Book id opened");
        }

        public void Close()
        {
            Console.WriteLine("Book is closed");
        }

        public void WriteIF(bool output, string txt)
        {
            if (output == false)
            {
                return; // 값의 반환 말고도 점프 구문의 역할도 있다.
            }

            Console.WriteLine(txt);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            book b = new book();
            b.WriteIF(false, "kieek");
            Console.ReadKey();
        }
    }
}
