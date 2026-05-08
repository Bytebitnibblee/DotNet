using System;

namespace CompareDemo_Program_608
{
    class CompareDemo
    {
        public int value;

        public CompareDemo(int v)
        {
            value = v;
        }

        public static bool operator >(CompareDemo a, CompareDemo b)
        {
            return a.value > b.value;
        }

        public static bool operator <(CompareDemo a, CompareDemo b)
        {
            return a.value < b.value;
        }

        static void Main()
        {
            CompareDemo x = new CompareDemo(10);
            CompareDemo y = new CompareDemo(20);

            Console.WriteLine(x > y);
        }
    }
}