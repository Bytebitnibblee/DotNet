using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface A
    {
        void sum();
    }

    interface B
    {
        void prod();
    }

   
    class Calculate : A, B
    {
        int x = 10, y = 5;

        public void sum()
        {
            Console.WriteLine("Sum = " + (x + y));
        }

        public void prod()
        {
            Console.WriteLine("Product = " + (x * y));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate obj = new Calculate();

            obj.sum();
            obj.prod();

            Console.ReadLine();
        }
    }
}