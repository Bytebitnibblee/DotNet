using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5; b = 6; c = 9;

            if(a>b && a>c)
            {
                Console.WriteLine("a is the greatest number");
            } else if(b>a && c>a)
            {
                Console.WriteLine("\n b is the greatest number");
            }
            else
            {
                Console.WriteLine("c is the greatest number");
            }
        }
    }
}
