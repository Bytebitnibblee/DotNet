using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArr = new int[3][];

            jaggedArr[0] = new int[2] { 3, 5 };
            jaggedArr[1] = new int[4] { 10, 20, 30, 40 };
            jaggedArr[2] = new int[3] { 3, 5, 7 };
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write("Element({0})", i + 1);
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write(jaggedArr[i][j]);
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}

