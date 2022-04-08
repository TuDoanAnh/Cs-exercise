using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Move
    {
        public int MoveId { get; set; }
        public string MoveName { get; set; }
        public int TypeId { get; set; }
        public string MoveCat { get; set; }
        public int? MovePower { get; set; }
        public int Pp { get; set; }

        public virtual Type Type { get; set; }
    }
}
