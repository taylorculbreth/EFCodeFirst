using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                Student stud = new Student()
                {
                    StudentName = "new student"
                };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
