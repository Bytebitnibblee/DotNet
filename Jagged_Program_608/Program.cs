using System;
namespace Jagged_Program_608
{
    class Jagged_Program_608
    {
        static void Main(string[]args)
        {
            int[][] data = new int[2][];
            data[0] = new int[] { 1, 2 };
            data[1] = new int[] { 3, 4, 5 };

            for (int i = 0; i < data.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < data[i].Length; j++)
                {
                    sum += data[i][j];
                }
                Console.WriteLine(sum);
            }
        }
    }
}