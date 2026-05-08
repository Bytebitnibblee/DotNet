using System;
namespace MatrixMul_Program_608
{
    class MatrixMul_Program_608
    {
        static void Main(string[]args)
        {
            int[,] a = { { 1, 2 }, { 3, 4 } };
            int[,] b = { { 5, 6 }, { 7, 8 } };
            int[,] res = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    res[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        res[i, j] += a[i, k] * b[k, j];
                    }
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}