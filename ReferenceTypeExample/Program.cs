using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypeExample
{
      class Student
    {
        public int age = 10;
        public string str = "Deep";
       }

        internal class Program
    {
        static void main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = student1;

            Console.WriteLine("age"= student1.age + "\n" + "Age:" + student2.age);
            Console.WriteLine("Name:" + student1.str + "\n" + "Name:" + student2.str);
            Console.ReadLine();

        }
    }
}
