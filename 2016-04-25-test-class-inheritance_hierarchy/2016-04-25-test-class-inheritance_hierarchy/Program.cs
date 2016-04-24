using System;

namespace _2016_04_25_test_class_inheritance_hierarchy
{
    class grandFather
    {
        public int gage;

        public void grandage()
        {
            Console.WriteLine(gage);
        }

    }

    class father : grandFather
    {
        public int fage;

        public void fatherage()
        {
            Console.WriteLine(fage);
        }

    }

    class me : father
    {
        public int age;
        
        public void meage()
        {
            Console.WriteLine(age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            me m = new me();
            m.age = 21;
            m.meage();
            m.fage = m.age + 30;
            m.fatherage();
            m.gage = m.fage + 30;
            m.grandage();

            Console.ReadKey();
        }
    }
}
