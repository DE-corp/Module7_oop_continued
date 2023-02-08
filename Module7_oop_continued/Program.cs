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

	class Car<TEngine> where TEngine : Engine
	{
		public TEngine Engine;

		public virtual void ChangePart<TPart>(TPart newPart) where TPart : Part
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