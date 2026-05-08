using System;

namespace GenericMethod_Program_608
{
    class GenericMethodDemo
    {
        public void Print<T>(T value)
        {
            Console.WriteLine(value);
        }

        static void Main()
        {
            GenericMethodDemo obj = new GenericMethodDemo();
            obj.Print(10);
            obj.Print("Hello");
        }
    }
}