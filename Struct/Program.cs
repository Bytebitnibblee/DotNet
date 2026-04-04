using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct SimpleStructDemo
    {
        public int id;
        public string name;

        public SimpleStructDemo(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
        void display()
        {
            Console.WriteLine("Name" + name);
            Console.WriteLine("ID:" + id);
        }


        public class Program
        {
            static void Main(string[] args)
            {
                SimpleStructDemo demo = new SimpleStructDemo();
                demo.id = 101;
                demo.name = "Deep Singh Rawal";
                Console.WriteLine("ID:{0}", demo.id);
                Console.WriteLine("Name: {0}", demo.name);
                Console.ReadLine();
            }
        }
    }
}
