    using System;

    namespace SwitchCases_Program_608
    {
        class GradeDemo
        {
            static void Main()
            {
                int marks;

                Console.Write("Enter marks: ");
                marks = Convert.ToInt32(Console.ReadLine());

                switch (marks / 10)
                {
                    case 10:
                    case 9:
                    case 8:
                        Console.WriteLine("Grade: A");
                        break;

                    case 7:
                        Console.WriteLine("Grade: B");
                        break;

                    case 6:
                        Console.WriteLine("Grade: C");
                        break;

                    case 5:
                        Console.WriteLine("Grade: D");
                        break;

                    default:
                        Console.WriteLine("Grade: Fail");
                        break;
                }
            }
        }
    }