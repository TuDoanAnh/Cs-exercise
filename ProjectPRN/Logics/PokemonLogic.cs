using ProjectPRN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.Logics
{
    internal class PokemonLogic
    {
        public List<Pokemon> GetAllPokemons()
        {
            using(var context = new PokedexContext())
            {
                context.Types.ToList();
                context.Categories.ToList();
                List<Pokemon> pokemons = context.Pokemons.ToList();
                return pokemons;
            }
        }

        public Pokemon GetPokemonById(int id)
        {
            using(var context = new PokedexContext())
            {
                Pokemon pokemon = context.Pokemons.FirstOrDefault(x => x.PokeId == id);
                return pokemon;
            }
        }

        public List<Pokemon> GetPokemonByName(string name)
        {
            using(var context = new PokedexContext())
            {
               return context.Pokemons.Where(x => x.PokemonName.Contains(name)).ToList();   
            }
        }
    }
}
