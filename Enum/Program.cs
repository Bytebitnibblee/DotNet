using System;

namespace EnumExample
{
    enum year
    {
        January = 10,
        February = 1,
        March = 3,
        April,
        May = 11,
        June = 12
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Year Enumeration Values:");

            foreach (year strYear in Enum.GetValues(typeof(year)))
            {
                Console.WriteLine(strYear);
            }

            Console.WriteLine();
            Console.WriteLine("The value of January in year: " + (int)year.January);
            Console.WriteLine("The value of February in year: " + (int)year.February);
            Console.WriteLine("The value of March in year: " + (int)year.March);
            Console.WriteLine("The value of April in year: " + (int)year.April);
            Console.WriteLine("The value of May in year: " + (int)year.May);
            Console.WriteLine("The value of June in year: " + (int)year.June);

            Console.ReadLine();
        }
    }
}