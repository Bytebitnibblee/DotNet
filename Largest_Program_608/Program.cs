using System;
namespace LargestProgram_608 {

    class Largest_Program_608
    {
        static void Main(string[]args)
        {
            int a = 5, b = 9, c = 3;

            int max = (a > b) ? (a > c ? a : c) : (b > c ? b : c);

            Console.WriteLine(max);
        }
    }
}