using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Number
{
    public int value;

    public Number(int v)
    {
        value = v;
    }

    public static bool operator >(Number a, Number b)
    {
        return a.value > b.value;
    }

    public static bool operator <(Number a, Number b)
    {
        return a.value < b.value;
    }
}

class Program
{
    static void Main()
    {
        Number n1 = new Number(10);
        Number n2 = new Number(20);

        if (n1 > n2)
            Console.WriteLine("n1 is greater");
        else
            Console.WriteLine("n2 is greater");
    }
}