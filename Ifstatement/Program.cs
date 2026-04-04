using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifstatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("enter a number:");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) { 
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("It is an Odd number");
            }

        }
    }
}
