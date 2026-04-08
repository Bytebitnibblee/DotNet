using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    public class Student
    {
        public static void display<T>(T[] id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                Console.WriteLine(id[i]);
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                int[] nos = new int[3];
                nos[0] = 101;
                nos[1] = 102;
                nos[2] = 103;
                Student.display(nos);

                string[] names = { "Deep", "Kirtan", "Sangam" };
                Student.display(names);

                double[] values = { 608.99, 607.99, 608.99 };
                Student.display(values);
                Console.ReadLine();

            }
        }
    }
}
