using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithimeticOperator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("enter three numbers");
          
             a = int.Parse(Console.ReadLine());
             b = int.Parse(Console.ReadLine());
             c = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum:" + (a + b + c));
            Console.WriteLine("Multiply:" +(a* b* c));
            Console.WriteLine("Division:" + (a / c));
            Console.WriteLine("Remainder:" + (a % b));
            Console.WriteLine("Remainder:" + (a - b));
            Console.ReadLine();
        }
    }
}
