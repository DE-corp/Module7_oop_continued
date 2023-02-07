using System;

namespace Module7_oop_continued
{
	class ElectricEngine { }

	class GasEngine { }

	class Battery { }

	class Differential { }

	class Wheel { }

	class Car<T1>
	{
		public T1 Engine;

		public virtual void ChangePart<T2>(T2 newPart)
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