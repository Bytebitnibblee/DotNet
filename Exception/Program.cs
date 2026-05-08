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
                Console.WriteLine("This will not be printed"+div);
            }
            catch (ArithmeticException ae)

            {
                Console.WriteLine("Division by zero");
                Console.WriteLine(ae.Message);
                Console.WriteLine(ae.GetType());
            }
            try
            {
                int[] arr = { 10, 20, 30, 40 };
                Console.WriteLine(arr[6]);
            }
            catch (Exception at)
            {
                Console.WriteLine(at .Message);
            }
            Console.ReadLine();
        }
    }
}