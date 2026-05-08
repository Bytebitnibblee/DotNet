using System;

namespace Program_608
{
    class Base
    {
        public virtual void Show()
        {
            Console.WriteLine("Base Method");
        }
    }

    class OverrideDemo : Base
    {
        public override void Show()
        {
            Console.WriteLine("Override Method");
        }

        static void Main()
        {
            OverrideDemo obj = new OverrideDemo();
            obj.Show();
        }
    }
}