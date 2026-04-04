using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstructor
{
    internal class Program
    {
        string name;
        int age;
        public void acceptData(string name, int age )
        {
            this.name = name;
            this.age = age;

        }
        public void displayData()
        {
            Console.WriteLine("Name: {0} \nAGe: {1}", name, age);
        }
        static void Main(string[] args)
        {
            Program Program = new Program();
            Program.acceptData("Deep", 5);
            Program.displayData();
            Console.ReadLine();

        }
    }
}
