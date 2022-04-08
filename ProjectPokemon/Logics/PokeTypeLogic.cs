using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPokemon.Models;
namespace ProjectPokemon.Logics
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
    }
}
