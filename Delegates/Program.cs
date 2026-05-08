using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int SumOperation(int x, int y);
    internal class Program
    {
        static int Addition (int a , int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            SumOperation obj = new SumOperation(Program.Addition);
            Console.WriteLine(obj(23,27));
            Console.ReadLine();
        }
    }
}
