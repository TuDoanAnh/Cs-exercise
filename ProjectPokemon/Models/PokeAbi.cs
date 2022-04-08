using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPokemon.Models
{
    public partial class PokeAbi
    {
        public int PokeId { get; set; }
        public int AbiId { get; set; }

        public virtual Ability Abi { get; set; }
        public virtual Pokemon Poke { get; set; }
    }
}
