using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swapping");
            Console.WriteLine("a =" +a);
            Console.WriteLine("b =" +b);
        }
    }
}
