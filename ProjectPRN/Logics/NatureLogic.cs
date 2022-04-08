using ProjectPRN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.Logics
{
    internal class NatureLogic
    {
        public List<Nature> GetAllNature()
        {   
            using(var context = new PokedexContext())
            {
                return context.Natures.ToList();
            }
        }

        public Nature GetNatureByID(int id)
        {
            Nature nature = null;
            using(var context = new PokedexContext())
            {
                nature = context.Natures.FirstOrDefault(x => x.NatureId == id); 
            }
            return nature;
        }
    }
}
