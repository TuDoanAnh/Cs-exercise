using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class GamePatch
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string Plot { get; set; }
        public string Main { get; set; }
        public string Professor { get; set; }
        public string GymLeader1 { get; set; }
        public string GymLeader2 { get; set; }
        public string GymLeader3 { get; set; }
        public string GymLeader4 { get; set; }
        public string GymLeader5 { get; set; }
        public string GymLeader6 { get; set; }
        public string GymLeader7 { get; set; }
        public string GymLeader8 { get; set; }
        public string Elite4 { get; set; }
        public string Enimies { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Platform { get; set; }
        public string Players { get; set; }
        public string Connectivity { get; set; }
        public int? Gen { get; set; }
        public int? Release { get; set; }
    }
}
