using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Ability
    {
        public Ability()
        {
            PokeAbis = new HashSet<PokeAbi>();
        }

        public int AbiId { get; set; }
        public string Effect { get; set; }
        public string AbilityName { get; set; }

        public virtual ICollection<PokeAbi> PokeAbis { get; set; }
    }
}
