using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Type
    {
        public Type()
        {
            Moves = new HashSet<Move>();
            PokemonTypeId2Navigations = new HashSet<Pokemon>();
            PokemonTypes = new HashSet<Pokemon>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public double NormalRate { get; set; }
        public double FireRate { get; set; }
        public double WaterRate { get; set; }
        public double GrassRate { get; set; }
        public double ElectricRate { get; set; }
        public double IceRate { get; set; }
        public double FightingRate { get; set; }
        public double PoisonRate { get; set; }
        public double GroundRate { get; set; }
        public double FlyingRate { get; set; }
        public double PsychicRate { get; set; }
        public double BugRate { get; set; }
        public double RockRate { get; set; }
        public double GhostRate { get; set; }
        public double DragonRate { get; set; }
        public double DarkRate { get; set; }
        public double SteelRate { get; set; }
        public double FairyRate { get; set; }

        public virtual ICollection<Move> Moves { get; set; }
        public virtual ICollection<Pokemon> PokemonTypeId2Navigations { get; set; }
        public virtual ICollection<Pokemon> PokemonTypes { get; set; }
    }
}
