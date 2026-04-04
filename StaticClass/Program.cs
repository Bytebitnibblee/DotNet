using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{

    public static class StaticClass
    {
        public static int n = 5;
        public static void staticMethod()
        {
            Console.WriteLine("Inside Static Method");
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("The static value is:" + StaticClass.n);
        Console.WriteLine("Value od static Variable:{0}", StaticClass.n);
        StaticClass.staticMethod();
        Console.ReadLine();
        }
    }
}
