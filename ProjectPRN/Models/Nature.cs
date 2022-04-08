using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Nature
    {
        public int NatureId { get; set; }
        public string NatureName { get; set; }
        public string IncreaseStat { get; set; }
        public string DecreaseStat { get; set; }
    }
}
