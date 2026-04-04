using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    internal class StaticMethods
    {

        int a = 5;
        static int b = 10;

        static void staticMethod()
        {
            Console.WriteLine("B:" + b);
        }

        void nonStaticMethod()
        {
            Console.WriteLine("A:" + a);        
        }
        static void Main(string[] args)
        {
            StaticMethods obj = new StaticMethods();
            obj.nonStaticMethod();
            staticMethod();
            Console.ReadLine();
        }
    }
}
