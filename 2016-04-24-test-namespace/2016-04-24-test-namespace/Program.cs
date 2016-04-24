using System;

namespace test
{
    class Program
    {
        public void p()
        {
            Console.WriteLine("test 네임 스페이스 p() 함수 실행");
        }

    }

}

namespace _2016_04_24_test_namespace
{
    class Program
    {
        public void p()
        {
            Console.WriteLine("_2016_04_24_test_namespace 네임 스페이스 p() 함수 실행");

        }
        static void Main(string[] args)
        {
            test.Program A = new test.Program();
            A.p();
            _2016_04_24_test_namespace.Program B = new _2016_04_24_test_namespace.Program();
            B.p();
            Console.ReadKey();

        }
    }
}
