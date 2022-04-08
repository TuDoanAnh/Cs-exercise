using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Account
    {
        public int AccId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Poke1 { get; set; }
        public string Poke2 { get; set; }
        public string Poke3 { get; set; }
        public string Poke4 { get; set; }
        public string Poke5 { get; set; }
        public string Poke6 { get; set; }
        public string RoleId { get; set; }
    }
}
