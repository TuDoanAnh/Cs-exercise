using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Logic
{
    internal class StudentLogic
    {
        public List<Student> getAllStudents()
        {
            using(APDatabaseContext context = new APDatabaseContext())
            {
                return context.Students.ToList();
            }
        }
    }
}
