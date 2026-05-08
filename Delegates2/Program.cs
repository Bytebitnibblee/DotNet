using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DelegatesMulticast
{
    public delegate void operation(int x, int y);
    internal class Program { 
  static void Main(string[] args)
        {
            operation obj = Calculation.Add;
            obj += Calculation.Multiple;
            obj += Calculation.Sub;
            obj(10, 5);
            Console.ReadLine();
        }
    }
    public class Calculation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(a- b);
        }

        public static void Multiple(int a, int b)
        {
            Console.WriteLine(a * b);
        }
   
    }
}
