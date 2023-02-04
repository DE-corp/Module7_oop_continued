using System;

namespace Module7_oop_continued
{
    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, 5, 6 };
            IndexingClass IndClass = new IndexingClass(array);

            int el = IndClass[2];
            Console.WriteLine(el);

            Console.ReadLine();
        }
    }
}