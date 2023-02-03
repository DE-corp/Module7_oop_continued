using System;

namespace Module7_oop_continued
{
    class BaseClass
    {
        protected string Name;
        public virtual int Counter {get; set;}

        public BaseClass(string name)
        {
            Name = name;
        }

    }

    class DerivedClass : BaseClass
    {
        public string Description;
        private int counter;
        public override int Counter 
        {
            get
            {
                return counter;
            }

            set
            {
                if (value > 0)
                {
                    counter = value;
                }
            }
        }

        public DerivedClass(string Name, string Description) : base(Name)
        {
            this.Description = Description;   
        }
        
        public void Show()
        {
            Console.WriteLine($"Name: {base.Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Counter: {counter}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var derivedClass = new DerivedClass("Дмитрий", "Dmitry");
            derivedClass.Counter = -3;
            derivedClass.Show();

            Console.ReadLine();
		}
    }
}
