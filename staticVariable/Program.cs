using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticVariable
{
    internal class staticVariable
    {
        static int a = 5;
        void display()
        {
            int b = 10;
            Console.WriteLine("A=" + a);
            Console.WriteLine("B=" + b);

            a++;
            b++;
        }
        static void Main(string[] args)
        {
            staticVariable obj = new staticVariable();
            obj.display();
            obj.display();
            Console.ReadLine();
        }
    }
}
