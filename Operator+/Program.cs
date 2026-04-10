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

    public static Number operator +(Number a, Number b)
    {
        return new Number(a.value + b.value);
    }
}

class Program
{
    static void Main()
    {
        Number n1 = new Number(10);
        Number n2 = new Number(20);

        Number result = n1 + n2;

        Console.WriteLine(result.value);
    }
}