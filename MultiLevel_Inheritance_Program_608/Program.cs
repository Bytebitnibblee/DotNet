using System;

namespace MultiLevel_Inheritance_Program_608
{
    class A
    {
        public void ShowA() => Console.WriteLine("Class A");
    }

    class B : A
    {
        public void ShowB() => Console.WriteLine("Class B");
    }

    class MultiLevelDemo : B
    {
        static void Main()
        {
            MultiLevelDemo obj = new MultiLevelDemo();
            obj.ShowA();
            obj.ShowB();
        }
    }
}