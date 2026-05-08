using System;

class ReferenceType_Program_608
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;

        arr2[0] = 99;

        Console.WriteLine(arr1[0]);
    }
}