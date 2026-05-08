using System;

namespace PropertyDemo_Program_608
{
    class PropertyDemo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        static void Main()
        {
            PropertyDemo p = new PropertyDemo();

            p.Id = 608;
            p.Name = "Deep Singh Rawal";
            p.Age = 21;

            Console.WriteLine(p.Id + " " + p.Name + " " + p.Age);
        }
    }
}