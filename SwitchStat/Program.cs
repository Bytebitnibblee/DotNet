using System;

namespace SwitchStat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Percentage:");
            int a = int.Parse(Console.ReadLine());

            int b;

            if (a < 30)
                b = 1;
            else if (a < 50)
                b = 2;
            else if (a < 75)
                b = 3;
            else if (a < 85)
                b = 4;
            else
                b = 5;

            switch (b)
            {
                case 1:
                    Console.WriteLine("Nah buddy: you failed keep on trying dawg");
                    break;

                case 2:
                    Console.WriteLine("Fourth division");
                    break;

                case 3:
                    Console.WriteLine("Second division");
                    break;

                case 4:
                    Console.WriteLine("You have secured first division");
                    break;

                case 5:
                    Console.WriteLine("You have achieved distinction");
                    break;

                default:
                    Console.WriteLine("Unknown Value");
                    break;
            }

            Console.ReadLine();
        }
    }
}