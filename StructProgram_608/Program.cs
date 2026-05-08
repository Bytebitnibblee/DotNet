using System;

namespace StructProgram_608
{
    struct Student
    {
        public int id;
        public string name;
    }

    class StructDemo
    {
        static void Main()
        {
            Student d;
            d.id = 608;
            d.name = "Deep";

            Console.WriteLine(d.id + " " + d.name);
        }
    }
}