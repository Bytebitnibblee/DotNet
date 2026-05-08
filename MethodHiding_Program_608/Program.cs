using System;

namespace MethodHiding_Program_608
{
    class Parent
    {
        public void Show()
        {
            Console.WriteLine("Parent Method");
        }
    }

    class HidingDemo : Parent
    {
        public new void Show()
        {
            Console.WriteLine("Hidden Method");
        }

        static void Main()
        {
            HidingDemo obj = new HidingDemo();
            obj.Show();
        }
    }
}