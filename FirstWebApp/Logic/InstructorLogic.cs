

using FirstWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace FirstWebApp.Logic
{
    public class InstructorLogic
    {
        public List<Instructor> ListAllInstructor()
        {
            using(var context = new APDatabaseContext())
            {
                return context.Instructors.ToList();
            }
        }
    }
}
