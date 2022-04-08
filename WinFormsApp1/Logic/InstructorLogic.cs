using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Logic
{
    internal class InstructorLogic
    {
        public List<Instructor> getAllInstructor()
        {
            using(APDatabaseContext context = new APDatabaseContext())
            {
                return context.Instructors.ToList();
            }
        }
    }
}
