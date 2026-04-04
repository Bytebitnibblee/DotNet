using System;

namespace SetExamplee
{
    class Student
    {
        private int id;
        private string name;

        public int StdProperties
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter your Name!");
                }
                else
                {
                    this.name = value;
                }
            }
            get
            {
                return this.name;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.StdProperties = 10;
            student.Name = "deep";

            Console.WriteLine("ID: " + student.StdProperties);
            Console.WriteLine("Your Name is: " + student.Name);

            Console.ReadLine();
        }
    }
}