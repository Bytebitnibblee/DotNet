using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    internal class Program
    {
        static void displayArray(int[] Array)
        {
            int i, sum = 0;
            Console.WriteLine("You Entered Numbers are:\t");

            for (i = 0; i < 4; i++)
            {
                Console.Write("\t" + Array[i]);
                sum = sum + Array[i];
            }

            Console.Write("\nSum of all value is:\t{0}", sum);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[4];
            int i;

            Console.Write("Please Enter your number:\n");

            for (i = 0; i < 4; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Program.displayArray(arr);

        }
    }
}