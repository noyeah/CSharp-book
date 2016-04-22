using System;

namespace _2016_04_23_test_class_singleton_class
{
    class Person
    {
        static public Person president = new Person("생성자 앞에 private 붙이면 new 연산자못써서 객체 생성 못하지롱~ 이거시! 싱글톤 클래스 이니라!!! 음하핳");

        string _name;

        private Person(string name)
        {
            _name = name;
        }

        public void DisplayName()
        {
            Console.WriteLine(_name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person.president.DisplayName();
            Console.ReadKey();
        }
    }
}
