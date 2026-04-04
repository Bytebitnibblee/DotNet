using System;

namespace Overloading
{
    internal class Program
    {
        public class Demo
        {
            public void show(int a)
            {
                Console.WriteLine("One value: " + a);
            }

            public void show(int a, int b)
            {
                Console.WriteLine("Two values: {0}, {1}", a, b);
            }

            public void show(int a, int b, int c)
            {
                Console.WriteLine("Three values: {0}, {1}, {2}", a, b, c);
            }
        }

        static void Main(string[] args)
        {
            Demo demo = new Demo();

            demo.show(10);
            demo.show(10, 20);
            demo.show(10, 20, 30);
        }
    }
}