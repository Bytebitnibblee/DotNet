using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding
{
    internal class StaticBinding
    {
        public void display()
        {
            string str = "Deep";
            Console.WriteLine("Welcome to static Binding.\t" + str);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            StaticBinding staticBinding = new StaticBinding();
            staticBinding.display();
        }
    }
}
