using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Category
    {
        public Category()
        {
            Pokemons = new HashSet<Pokemon>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }

        public virtual ICollection<Pokemon> Pokemons { get; set; }
    }
}
