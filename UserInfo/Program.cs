using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo
{
    internal class User_details
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your name:");
            string name = Console.ReadLine();


            Console.WriteLine("please enter your address:");
            string address = Console.ReadLine();


            Console.WriteLine("please enter your salary:");
             float salary = float.Parse(Console.ReadLine());

            Console.WriteLine($"Hello {name}\nYour ID is {id}\nYou are from {address}\nYour salary is {salary}");

        }
    }
}
