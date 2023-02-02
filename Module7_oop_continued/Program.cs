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

        public void Show()
        {
            Console.WriteLine($"Name: {base.Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Counter: {Counter}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var DerivedClass = new DerivedClass("Дмитрий", "Dmitry", 100);
            DerivedClass.Show();

            Console.ReadLine();
		}
    }
}
