using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class EvoChain
    {
        public EvoChain()
        {
            Pokemons = new HashSet<Pokemon>();
        }

        public int EvoId { get; set; }
        public string Stage1 { get; set; }
        public string Stage2 { get; set; }

        public virtual ICollection<Pokemon> Pokemons { get; set; }
    }
}
