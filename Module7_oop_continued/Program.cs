using System;

namespace Module7_oop_continued
{
	class Car<T>
    {
		public T Engine;

	}

	class ElectricEngine
    {

    }

	class GasEngine
    {
		public string str = "Бензин";
    }

	class Program
	{
		static void Main(string[] args)
		{
			var car = new Car<GasEngine>();
			var car2 = new Car<ElectricEngine>();

            Console.ReadLine();
		}
	}

}