using System;
namespace SplitProgram_608
{

    class Split_Program_608
    {
        static void Main(string[]args)
        {
            string text = "My name is Deep Singh Rawal";
            string[] parts = text.Split(' ');

            foreach (string word in parts)
            {
                Console.WriteLine(word);
            }
        }
    }
}