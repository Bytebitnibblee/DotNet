using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetExample
{
    class Student
    {
        private int fixStudent = 30;
        public int totalStudent
        {
            get
            {
                return fixStudent;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Student obj = new Student();
                Console.WriteLine(obj.totalStudent);
                Console.ReadLine();
            }
        }
    }
}


