using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWindWF.Models;

namespace NorthWindWF.Logics
{
    class CustomerLogic
    {
        public List<Customer> getAllCustomer()
        {
            using(var context = new NorthwindContext())
            {
                return context.Customers.ToList();
            }
        }
    }
}
