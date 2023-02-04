using System;

namespace Module7_oop_continued
{
    class Obj
    {
        public int Value;

        public static Obj operator +(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value + b.Value
            };
        }

        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var firstObj = new Obj { Value = 3};
            var secondObj = new Obj { Value = 7 };
            Obj c = firstObj + secondObj;
            Obj d = firstObj - secondObj;

            Console.WriteLine(c.Value);
            Console.WriteLine(d.Value);

            Console.ReadLine();
        }
    }
}