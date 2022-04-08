using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWindWF.Models;

namespace NorthWindWF.Logics
{
    internal class EmployeeLogic
    {
        public List<Employee> getAllEmployees()
        {
            using(var context = new NorthwindContext())
            {
                return context.Employees.ToList();
            }
        }
    }
}
