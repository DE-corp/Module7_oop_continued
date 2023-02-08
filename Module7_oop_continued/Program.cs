using System;

namespace Module7_oop_continued
{
	abstract class Engine {}

	class ElectricEngine: Engine { }

	class GasEngine: Engine { }

	abstract class Part { }

	class Battery: Part { }

	class Differential : Part { }

	class Wheel : Part { }

	abstract class Car<TEngine> where TEngine : Engine
	{
		public TEngine Engine;

		public virtual void ChangePart<TPart>(TPart newPart) where TPart : Part
		{

		}

	}

	class ElectricCar: Car<ElectricEngine> 
	{
		public override void ChangePart<TPart>(TPart newPart)
		{

		}
	}

	class GasCar : Car<GasEngine> 
	{
		public override void ChangePart<TPart>(TPart newPart)
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