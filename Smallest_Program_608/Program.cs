using System;
namespace Smallest_Program_608
{
    class Smallest_Program_608
    {
        static void Main()
        {
            int a = 5, b = 2, c = 8;

            if (a < b && a < c)
                Console.WriteLine(a);
            else if (b < c)
                Console.WriteLine(b);
            else
                Console.WriteLine(c);
        }
    }
}