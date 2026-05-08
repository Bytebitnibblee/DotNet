using System;
namespace FibonacciSeries_608
{

    class Fibonacci_Program_608
    {
        static void Main(string[]args)
        {
            int n = 6, a = 0, b = 1;

            Console.Write(a + " " + b + " ");

            for (int i = 2; i < n; i++)
            {
                int next = a + b;
                Console.Write(next + " ");
                a = b;
                b = next;
            }
        }
    }
}