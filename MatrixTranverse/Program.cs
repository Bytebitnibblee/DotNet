using System;

namespace MatrixAddition3x3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];
            int[,] sum = new int[3, 3];

            Console.WriteLine("Enter elements of First 3x3 Matrix:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Matrix1 [{i},{j}] : ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEnter elements of Second 3x3 Matrix:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Matrix2 [{i},{j}] : ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

           
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Print Sum Matrix
            Console.WriteLine("\nSum Matrix:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }

            
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < 3; i++)
            {
                primaryDiagonal += sum[i, i];           
                secondaryDiagonal += sum[i, 2 - i];     
            }

            Console.WriteLine("\nPrimary Diagonal Sum: " + primaryDiagonal);
            Console.WriteLine("Secondary Diagonal Sum: " + secondaryDiagonal);
        }
    }
}