using System;

namespace Module7_oop_continued
{
	class Engine {}

	class ElectricEngine: Engine { }

	class GasEngine: Engine { }

	class Part { }

	class Battery: Part { }

	class Differential : Part { }

	class Wheel : Part { }

	class Car<T> where T: Engine
	{
		public T Engine;

		public virtual void ChangePart<T2>(T2 newPart) where T2: Part
		{

		}

	}

	class Program
	{
		static void Main(string[] args)
		{

            Console.ReadLine();
		}
	}

}