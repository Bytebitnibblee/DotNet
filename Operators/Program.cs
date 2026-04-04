using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, Large;

            /* public static void main(string[] args) {
             if (a < b && a > c) {
                 Console.WriteLine("a is the largest number" + a);
             */

            Console.WriteLine("Enter First Number:");
            a =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Third Number:");
            c = int.Parse(Console.ReadLine());

            Large = (a > b) ? (a > c ? a : c) : (b > c ? b : c);
            Console.WriteLine("Largest Number is:" + Large);

        }
    }
}