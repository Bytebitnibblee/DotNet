using System;

namespace Inheritance
{
    internal class SingleInheritance
    {
   
        public class Parent
        {
            string name;
            int age;

           
            public Parent(string n, int a)
            {
                name = n;
                age = a;
            }

           
            public void displayParent()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
            }
        }

     
        public class Child : Parent
        {
            string school;

            public Child(string n, int a, string s) : base(n, a)
            {
                school = s;
            }

         
            public void displayChild()
            {
                Console.WriteLine("School: " + school);
            }
        }

      
        static void Main(string[] args)
        {
            Child obj = new Child("Deep", 20, "Deerwalk College");

            obj.displayParent();
            obj.displayChild();   
        }
    }
}