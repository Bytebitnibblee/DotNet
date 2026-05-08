using System;

namespace AbstractClass_Program_608
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class AbstractDemo : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing...");
        }

        static void Main()
        {
            AbstractDemo obj = new AbstractDemo();
            obj.Draw();
        }
    }
}