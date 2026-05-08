using System;

class Counter
{
    public int value;

    public Counter(int v)
    {
        value = v;
    }

    // Unary ++ operator
    public static Counter operator +(Counter c)
    {
        return new Counter(c.value + 1);
    }

    // Relational == operator
    public static bool operator ==(Counter a, Counter b)
    {
        return a.value == b.value;
    }

    public static bool operator !=(Counter a, Counter b)
    {
        return a.value != b.value;
    }

    // Override Equals and GetHashCode
    public override bool Equals(object obj)
    {
        if (obj is Counter c)
            return value == c.value;
        return false;
    }

    public override int GetHashCode()
    {
        return value.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        Counter c1 = new Counter(5);
        Counter c2 = new Counter(5);

        c1++;
        Console.WriteLine("c1 value: " + c1.value);

        Console.WriteLine("c1 == c2: " + (c1 == c2));
    }
}