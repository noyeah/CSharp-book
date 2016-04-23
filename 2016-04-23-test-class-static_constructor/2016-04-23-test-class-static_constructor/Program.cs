using System;

namespace _2016_04_23_test_class_static_constructor
{
    class Person
    {
        static public Person president;

        public string _name;

        private Person(string name)
        {
            _name = name;
        }

        static Person()
        {
            president = new Person("대통령");
            Console.WriteLine("정적 생성자 실행됨");
        }

        public void output()
        {
            Console.WriteLine(_name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("메인 함수 실행 (메모리에는 이미 정적 필드와 객체가 생성되어있다)");
            Person.president.output();
            Console.WriteLine("- 정적 생성자는 최초로 접근하는 시점에 단 한번만 실행된다 -");
            Console.WriteLine("- 정적 멤버를 처음 호출할 경우이거나 인스턴스 생성자를 통해 객체가 만들어 지는 시점 이라면 어떤 코드보다도 우선적으로 실행 -");
            Person.president.output();
            Console.ReadKey();
        }
    }
}
