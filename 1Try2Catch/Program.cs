using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IndexOutOfRangeException;
using System.

namespace _1Try2Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int b = 4;
                int div = b / a;
                Console.WriteLine("Cannot divide by Zero");
                Console.WriteLine(div);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            int[] arr = { 10, 20, 30, 40 };
            Console.WriteLine(arr[8]);
            catch (Exception ex)
            {
                Console.WriteLine("Array out of limit");
                Console.WriteLine(ex.Message);

            }
        }
    }
}
