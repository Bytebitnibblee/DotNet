using System;

namespace MatrixAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2, 2];
            int[,] matrix2 = new int[2, 2];
            int[,] sum = new int[2, 2];

            Console.WriteLine("Enter elements of First 2x2 Matrix:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Matrix1 [{i},{j}] : ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMatrix 1:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nEnter elements of Second 2x2 Matrix:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Matrix2 [{i},{j}] : ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatrix 2:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

     
            Console.WriteLine("\nSum of the matrices:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}