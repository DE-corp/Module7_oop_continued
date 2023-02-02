using System;

namespace Module7_oop_continued
{
	class Obj
	{
		private string name;
		private string owner;
		private int length;
		private int count;

		public Obj(string name, string ownerName, int objLength, int count)
		{
			this.name = name;
			owner = ownerName;
			length = objLength;
			this.count = count;
		}

		public void GetData()
        {
            Console.WriteLine(name);
			Console.WriteLine(owner);
			Console.WriteLine(length);
			Console.WriteLine(count);
		}
	}

	class Program
    {
        static void Main(string[] args)
        {
			var obj = new Obj("Имя", "Владелец", 100, 3);
			obj.GetData();
		}
    }
}
