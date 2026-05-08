using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Lambda
    {
        static void Main(string[] args)
        {
            /*  Func<int, int, int> add = (a,b) => a + b;
              Console.WriteLine(add(2, 3));
              Console.ReadLine();*/

            /* Func<int, int, int, int> multiply = (a, b, c) =>
             {
                 int result = a * b * c;
                 return result;
             };
             Console.WriteLine(multiply(3, 2,7));
             Console.ReadLine();*/

            //Action lambda

            /*Action greet = () => Console.WriteLine("Deep Singh Rawal");
            greet();*/

            //Func Lambda

           /* Func <int,int,int> subtract =(a,b) => a - b;
            Console.WriteLine(subtract(10, 7));
*/
           //Predicate Lambda

            /*Predicate<int> isEven = x => x % 2 == 0;
            Console.WriteLine(isEven(4));*/


        }
    }
}

