using System;

namespace GenericClass_Program_608
{
    class Box<T>
    {
        public T data;

        public void Show()
        {
            Console.WriteLine(data);
        }
    }

    class GenericClassDemo
    {
        static void Main()
        {
            Box<int> obj = new Box<int>();
            obj.data = 100;
            obj.Show();
        }
    }
}