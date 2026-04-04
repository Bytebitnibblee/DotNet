using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal abstract class AbstratDemo
    {
        public abstract void add();
        public abstract void sub(int a, int b);
    }

    class Abstract1 : AbstratDemo
    {
        static void Main(string[] args)
        {
            Abstract1 abstract1 = new Abstract1();
            abstract1.add();
            abstract1.sub(2, 1);
            Console.ReadLine();
        }
        public override void add()
        {
            Console.WriteLine("sum of (1+2)=" + (1 + 2));
        }
        public override void sub(int a, int b)
        {
            Console.WriteLine("Sub of (2-1)=" + (a - b));
        }

    }
}
