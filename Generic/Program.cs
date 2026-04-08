using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Student<T>
    {
        T id;
        public Student(T s_id)
        {
            this.id = s_id;
        }
            public T getId()
        { 
            return this.id;
        }
        
        }

    public class Program
    {
        static void Main(string[] args)
        {
            Student<int> student = new Student<int>(608);
            Console.WriteLine(student.getId());

            Student<string> student1 = new Student<string>("Deep Singh Rawal");
            Console.WriteLine(student1.getId());

            Student<double> student2 = new Student<double> (608.08);
            Console.WriteLine(student2.getId());
        }
    }
}
       
