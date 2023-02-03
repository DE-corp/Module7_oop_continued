using System;

namespace Module7_oop_continued
{
    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        public DerivedClass(string Name, string Description) : base(Name)
        {
            this.Description = Description;
        }
        public DerivedClass(string Name, string Description, int Counter) : base(Name)
        {
            this.Description = Description;
            this.Counter = Counter;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass("Дмитрий", "Описание");
            obj.Display();


            Console.ReadLine();
        }
    }
}