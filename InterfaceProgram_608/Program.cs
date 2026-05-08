using System;

namespace InterfaceProgram_608
{
    interface IDisplay
    {
        void Show();
    }

    class InterfaceDemo : IDisplay
    {
        public void Show()
        {
            Console.WriteLine("Interface Method");
        }

        static void Main()
        {
            InterfaceDemo obj = new InterfaceDemo();
            obj.Show();
        }
    }
}