using System;

namespace EnumProgram_608
{
    enum Days
    {
        Sunday, Monday, Tuesday
    }

    class EnumDemo
    {
        static void Main()
        {
            Days d = Days.Monday;
            Console.WriteLine(d);
        }
    }
}