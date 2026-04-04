using System;

namespace ParameterizedConstructorDemo
{

    public class Student
    {
        int id;
        string name;
        int age;
        public Student(int i, string n, int a)
        {
            id = i;
            name = n;
            age = a;
        }
        public void display()
        {
            Console.WriteLine("ID:" + id + "\t" + "Name:" + name + "\t" + "Age:" + age);
        }


        static void Main(string[] args)
        {
            Student obj = new Student(115, "Deep Singh Rawal", 19);
            obj.display();
        }
    }
}