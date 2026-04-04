using System;

namespace ConsoleApp3
{
  
    class Student
    {
        private int[] id = new int[5];

        public int this[int index]
        {
            set
            {
                id[index] = value;
            }
            get
            {
                return id[index];
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student[0] = 10;
            student[1] = 20;

            Console.WriteLine("Value at index 0: " + student[0]);
            Console.WriteLine("Value at index 1: " + student[1]);

            Console.ReadLine();
        }
    }
}