using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a;
            a = 10;
            Console.WriteLine("Value of myObject:" + a.GetType());

         
            a = 10;
            Console.WriteLine("Value of myObject:" + a.GetType());


            a = "Hello, World!";
            Console.WriteLine("Value of myObject:" + a.GetType());

            a= DateTime.Now;
            Console.WriteLine("Value of myObject:"+a.GetType());
            Console.WriteLine();
        }
    }
}
