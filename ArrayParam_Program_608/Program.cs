using System;
namespace ArrayParam_Program_608
{
    class ArrayParam_Program_608
    {
        static void Show(int[] nums)
        {
            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
        }

        static void Main()
        {
            int[] values = { 1, 2, 3 };
            Show(values);
        }
    }
}