using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPRN.Models;
namespace ProjectPRN.Logics
{
    internal class PokeTypeLogic
    {
        public List<Models.Type> getAllType()
        {
            using(var context = new PokedexContext())
            {
                return context.Types.ToList();
            }
        }

        public string GetNameByID(int id)
        {
            using(var context = new PokedexContext())
            {
                Models.Type type = context.Types.FirstOrDefault(x => x.TypeId == id);
                return type.TypeName;
            }
        }
    }
}
