using System;

namespace OverloadDemo_Program_608
{
    class OverloadDemo
    {
        void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        static void Main()
        {
            OverloadDemo obj = new OverloadDemo();
            obj.Add(2, 3);
            obj.Add(1, 2, 3);
        }
    }
}