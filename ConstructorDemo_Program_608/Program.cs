using System;

namespace ConstructorDemo_Program_608
{
    class ConstructorDemo
    {
        int id;
        string name;

        public ConstructorDemo(int idVal, string nameVal)
        {
            id = idVal;
            name = nameVal;
        }

        public void Show()
        {
            Console.WriteLine(id + " " + name);
        }

        static void Main()
        {
            ConstructorDemo obj = new ConstructorDemo(608, "Deep Singh Rawal");
            obj.Show();
        }
    }
}