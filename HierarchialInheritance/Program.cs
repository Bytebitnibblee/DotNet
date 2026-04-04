using System;

namespace HierarchialInheritance
{
    internal class Program
    {
        public class SuperClass
        {
            public void inputMethod()
            {
                Console.WriteLine("Please enter your name:");
            }
        }

        public class SubClass1 : SuperClass
        {
            public void showMethod()
            {
                Console.WriteLine("My name is Deep Singh Rawal.");
            }
        }

        public class SubClass2 : SuperClass
        {
            public void displayMethod()
            {
                Console.WriteLine("My name is Deep ko sathi.");
            }
        }

        static void Main(string[] args)
        {
            SubClass1 b = new SubClass1();
            SubClass2 c = new SubClass2();

            b.inputMethod();
            b.showMethod();

            c.inputMethod();
            c.displayMethod();
        }
    }
}