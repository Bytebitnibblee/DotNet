using System;
namespace Diagonal_Program_608
{
    class Diagonal_Program_608
    {
        static void Main(string[]args)
        {
            int[,] mat = { { 1, 2 }, { 3, 4 } };
            int sum = 0;

            for (int i = 0; i < 2; i++)
            {
                sum += mat[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}