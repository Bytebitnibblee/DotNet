using System;

class Parent
{
    public virtual void show()
    {
        Console.WriteLine("This is Parent class method");
    }
}

class Child : Parent
{
    public override void show()
    {
        Console.WriteLine("This is Child class method");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Child obj = new Child();
        obj.show();
    }
}