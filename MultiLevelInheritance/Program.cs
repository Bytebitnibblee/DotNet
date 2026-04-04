using System;

namespace MultiLevelInheritance
{
    internal class Program
    {
        public class Parent
        {
            protected string name;
            protected int age;

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
            protected string school;

            public Child(string n, int a, string s) : base(n, a)
            {
                school = s;
            }

            public void displayChild()
            {
                Console.WriteLine("School: " + school);
            }
        }

        public class GrandChild : Child
        {
            string favColor;

            public GrandChild(string n, int a, string s, string f) : base(n, a, s)
            {
                favColor = f;
            }

            public void displayGrandChild()
            {
                Console.WriteLine("Favorite Color: " + favColor);
            }
        }

        static void Main(string[] args)
        {
            GrandChild obj = new GrandChild("Deep", 20, "D College", "Blue");

            obj.displayParent();
            obj.displayChild();
            obj.displayGrandChild();
        }
    }
}