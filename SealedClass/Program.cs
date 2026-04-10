using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    sealed public class person
    {
        public void display()
        {
            Console.WriteLine("This is Sealed Class:");
        }
    }

    //public class SealedClass : person
    //{
    //    public void print()
    //    {
    //        Console.WriteLine("This is CLass");
    //    }

    //}

   internal  class Program
    {
        static void Main(string[] args) {
            person obj = new person();
            obj.display();
            Console.ReadLine();
        }
    }
}

        
        

