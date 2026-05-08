using System;

namespace AddOperator_Program_608
{
    class AddOperator
    {
        public int num;

        public AddOperator(int n)
        {
            num = n;
        }

        public static AddOperator operator +(AddOperator a, AddOperator b)
        {
            return new AddOperator(a.num + b.num);
        }

        static void Main()
        {
            AddOperator x = new AddOperator(5);
            AddOperator y = new AddOperator(10);

            AddOperator result = x + y;
            Console.WriteLine(result.num);
        }
    }
}