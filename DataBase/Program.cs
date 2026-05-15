using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_DataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext db= new DataClasses1DataContext();

            /*tb_student tb = new tb_student();
            tb.name = "Sangam Sunar";
          
            
            tb.address = "Butwal";
            
            tb.salary = 500;
            db.tb_students.InsertOnSubmit(tb);
            db.SubmitChanges();
            Console.WriteLine("Transferred");

            Console.ReadLine();*/
            /*
                        DataClasses1DataContext db = new DataClasses1DataContext();

                        var list = (from u in db.tb_students select u).ToList();
                        foreach (var u in list)
                        {
                            Console.WriteLine(u.name + "" + u.address + "" + u.salary);
                        }
                        Console.ReadLine();*/


            /*tb_student st = (from u in db.tb_students select u).Where(a => a.Id == 4).FirstOrDefault();
            st.name = "Ananta Raj Khanal";
            st.address = "Pokhara";
            st.salary = 10000;
            db.SubmitChanges();
            Console.WriteLine("Data inserted");
            Console.ReadLine();*/

            tb_student st = (from u in db.tb_students select u).Where(a => a.Id == 2).FirstOrDefault();
            db.tb_students.DeleteOnSubmit(st);
            db.SubmitChanges();
            Console.WriteLine("Record Deleted");
            Console.ReadLine();
        }
    }
}
