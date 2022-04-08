using FirstWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace FirstWebApp.Logic
{
    public class SubjectLogic
    {
        public List<Subject> ListAllSubject()
        {
            using(var context = new APDatabaseContext())
            {
                return context.Subjects.ToList();
            }
        }
    }
}
