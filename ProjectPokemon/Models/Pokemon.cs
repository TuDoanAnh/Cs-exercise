using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

#nullable disable

namespace ProjectPokemon.Models
{
    public partial class Pokemon
    {
        public Pokemon()
        {
            PokeAbis = new HashSet<PokeAbi>();
        }

        public int PokeId { get; set; }
        public string PokemonName { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public string Img { get; set; }
        public double? FemaleRate { get; set; }
        public double? MaleRate { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAttack { get; set; }
        public int SpDefense { get; set; }
        public int Speed { get; set; }
        public int? TypeId { get; set; }
        public int? CatId { get; set; }
        public int? EvoId { get; set; }
        public int? TypeId2 { get; set; }
        public int? Gen { get; set; }
        public string Describe { get; set; }

        public Image Picture
        {
            get
            {
                if (!string.IsNullOrEmpty(Img))
                {
                    if(File.Exists(Img))
                        return Image.FromFile(Img);
                }
                return null;
            }
        }
        public virtual Category Cat { get; set; }
        public virtual EvoChain Evo { get; set; }
        public virtual Type Type { get; set; }
        public virtual Type TypeId2Navigation { get; set; }
        public virtual ICollection<PokeAbi> PokeAbis { get; set; }
    }
}
