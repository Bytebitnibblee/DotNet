using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopexample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum=0;
            Console.WriteLine("Enter the integer:");
            int a= int.Parse(Console.ReadLine());

            for(int i=0; i<=a; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("The sum of numbers is:" + sum);
        }
    }
}
