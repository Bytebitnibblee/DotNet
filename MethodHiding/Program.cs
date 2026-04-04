using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class BaseClass
    {
        public virtual int display(int a, int b)
        {
            return (a + b);
        }

        public class DriveClass : BaseClass
        {
            public override int display(int a, int b)
            {
                return (a + b) * 2;
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                DriveClass driveClass = new DriveClass();
                Console.WriteLine(driveClass.display(5, 5));
                Console.ReadLine();

            }
        }
    }
}
