using System;

namespace SealedClassProgram_608
{
    sealed class FinalClass
    {
        public void Show()
        {
            Console.WriteLine("Sealed Class");
        }
    }

    class SealedDemo
    {
        static void Main()
        {
            FinalClass obj = new FinalClass();
            obj.Show();
        }
    }
}