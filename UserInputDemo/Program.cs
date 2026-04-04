using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace UserInputDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name:");
            string str=Console.ReadLine();

            Console.Write("Please enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is :" + str);
            Console.WriteLine("Your name is :" +age);
            Console.WriteLine();

            Console.WriteLine("Your name is :{0} {1}", str, age);
            Console.ReadLine(); 
        }
    }
}
