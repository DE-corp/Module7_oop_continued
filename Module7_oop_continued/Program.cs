using System;

namespace Module7_oop_continued
{
    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Работает процессор");
        }
    }

    class MotherBoard : ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Работает материнская карта");
        }
    }

    class GraphicCard : ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Используется GPU");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Gpu = new GraphicCard();
            var MBoard = new MotherBoard();
            var Cpu = new Processor();

            Cpu.Work();
            MBoard.Work();
            Gpu.Work();

            Console.ReadLine();
        }
    }
}