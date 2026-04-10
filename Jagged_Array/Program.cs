using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
   internal  class Program
    {
        static void Main()
        {
            int[][] arr = new int[3][];

            arr[0] = new int[] { 1, 2, 3 };
            arr[1] = new int[] { 4, 5 };
            arr[2] = new int[] { 6, 7,9,4 };

            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                    sum += arr[i][j];
                }

                Console.WriteLine(" Sum = " + sum);
            }
        }
    }
}