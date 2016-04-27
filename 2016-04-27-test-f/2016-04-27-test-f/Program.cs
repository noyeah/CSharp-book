using System;
using System.Collections.Generic;

namespace _2016_04_27_test_f
{
    class CHero
    {

        public int Kor { get; set; }
        public int Eng { get; set; }
        public string Name { get; set; }

        public CHero()
        {
            Console.WriteLine("생성자를 명시적을 선언했을경우 컴파일러가 기본생성자를 자동추가 안해줘서 일부러 넣음 빼애액");
        }

        public CHero(string name,int kor,int eng)
        {
            this.Name = name;
            this.Kor = kor;
            this.Eng = eng;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<CHero> hero = new List<CHero>();
            int[] En = new int[] { 88, 90, 99, 80, 95 };
            int[] Ko = new int[] { 84, 88, 94, 86, 94 };
            string[] Na = new string[] { "이순신", "장영실", "이세돌", "안중근", "김연아" };

            for (int i = 0; i < Na.Length; i++)
            {
                hero.Add(new CHero(Na[i],Ko[i],En[i]) { Name = Na[i], Kor = Ko[i], Eng = En[i] });
            }
            Console.WriteLine("테스트잼");

            foreach (CHero he in hero)
            {
                int sum = 0;
                sum = he.Kor + he.Eng;
                Console.WriteLine(he.Name +", " + sum);
            }
            Console.ReadKey();
        }

        
    }
}
