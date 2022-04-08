using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWindWF.Models;

namespace NorthWindWF.Logics
{
    internal class CountryLogic
    {
        public List<string> getAllCountries()
        {
            using(var context = new NorthwindContext())
            {
               return context.Orders.Select(o => o.ShipCountry).Distinct().ToList();
            }
        }
    }
}
