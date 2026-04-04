using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] result = new int[2, 2];

            Console.WriteLine("Enter elements of first matrix A:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix A: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++) ;
                Console.WriteLine(a[i, j] + " ");
            }
            Console.WriteLine();





            Console.WriteLine("Enter elements of second matrix B:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix B: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++) ;
                Console.WriteLine(b[i, j] + " ");
            }
            Console.WriteLine();


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = 0;

                    for (int k = 0; k < 2; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            Console.WriteLine("The Multiple of two matrix is :");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();


            }
        }
    }
}

