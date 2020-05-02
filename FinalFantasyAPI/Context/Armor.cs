using System;
using System.Collections.Generic;

namespace FinalFantasyAPI.Context
{
    public partial class Armor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? Absorb { get; set; }
        public long? Evade { get; set; }
        public long? TypeId { get; set; }

        public virtual ArmorType Type { get; set; }
    }
}
