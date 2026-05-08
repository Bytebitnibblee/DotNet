using System;

namespace ThisDemo_Program_608
{
    class ThisDemo
    {
        int number;

        public ThisDemo(int number)
        {
            this.number = number;
        }

        static void Main()
        {
            ThisDemo obj = new ThisDemo(50);
            Console.WriteLine(obj.number);
        }
    }
}