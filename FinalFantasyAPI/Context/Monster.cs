using System;
using System.Collections.Generic;

namespace FinalFantasyAPI.Context
{
    public partial class Monster
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string JpName { get; set; }
        public long? Hp { get; set; }
        public string Ap { get; set; }
        public long? Exp { get; set; }
        public long? Gold { get; set; }
        public string Category { get; set; }
        public string Weakness { get; set; }
        public string Resist { get; set; }
        public string Spells { get; set; }
        public long? IsBoss { get; set; }
    }
}
