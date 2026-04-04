using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloading
{
    class OperatorOverloading
    {
        public string str;
        public int a;

        public static OperatorOverloading operator +(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            OperatorOverloading obj3 = new OperatorOverloading();
            obj3.str = obj1.str + "" + obj2.str;
            obj3.a = obj1.a + obj2.a;
            return obj3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OperatorOverloading operatorOverloading = new OperatorOverloading();
            operatorOverloading.str = "Deep";
            operatorOverloading.a = 10;

            OperatorOverloading operatorOverloading1= new OperatorOverloading();
            operatorOverloading1.str = "Rawal";
            operatorOverloading1.a = 20;

            OperatorOverloading operatorOverloading2 = new OperatorOverloading();
            operatorOverloading2 = operatorOverloading + operatorOverloading1; 

            Console.WriteLine(operatorOverloading2.str);
            Console.WriteLine(operatorOverloading2.a);
            Console.ReadLine();
        }
    }
}

