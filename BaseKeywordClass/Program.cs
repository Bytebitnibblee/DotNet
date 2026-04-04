using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeywordClass
{
    public class BaseKeywordClass
    {
        public BaseKeywordClass(int age) {
            Console.WriteLine("AGE:" + age);
        }
        public string name = "Deep Singh Rawal";
        public string location = "Kathmandu";
        public void displayDetails()
        {
            Console.WriteLine("Name:{0}", name);

            Console.WriteLine("Loaction:{0}", location);

            Console.WriteLine("BaseCLass");

        }
    }
    public class DeriveKeywordClass : BaseKeywordClass
    {
        public DeriveKeywordClass() : base(10)
        {

        }
            public  new void displayDetails(){
            base.displayDetails();
            Console.WriteLine("Drive Class");
            }
            
        }

        

        public class Program { 
static void Main(string[] args)
        {
        DriveKeywordClass driveKeywordClass = new DriveKeywordClass();
        driveKeywordClass.displayDetails();
        Console.ReadLine();
        }
    }
}

