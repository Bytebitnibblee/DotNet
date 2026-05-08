using System;
namespace LoopControl_Program_608
{
    class LoopControl_Program_608
    {
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3) continue;
                if (i == 5) break;

                Console.WriteLine(i);
            }
        }
    }
}