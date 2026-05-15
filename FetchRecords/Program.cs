using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataClassesStudentDataContext db = new DataClassesStudentDataContext();

                var list = (from u in db.tb_linq_students select u).ToList        }
    }
}
