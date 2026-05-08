using System;

namespace BaseKeyword_Program_608
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Constructor");
        }
    }

    class BaseDemo : ParentClass
    {
        public BaseDemo() : base()
        {
            Console.WriteLine("Child Constructor");
        }

        static void Main()
        {
            BaseDemo obj = new BaseDemo();
        }
    }
}