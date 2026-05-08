using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutException_Exp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int div;
                div = a / b;
                Console.WriteLine("This will not be ");
            }
            catch (DivideByZeroException ex)

            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}