using System;

namespace IndexerDemo_Program_608
{
    class IndexerDemo
    {
        int[] values = new int[3];

        public int this[int i]
        {
            get { return values[i]; }
            set { values[i] = value; }
        }

        static void Main()
        {
            IndexerDemo obj = new IndexerDemo();

            obj[0] = 10;
            obj[1] = 20;

            Console.WriteLine(obj[1]);
        }
    }
}