using System;
using System.Collections.Generic;

namespace FinalFantasyAPI.Context
{
    public partial class ArmorType
    {
        public ArmorType()
        {
            Armor = new HashSet<Armor>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Armor> Armor { get; set; }
    }
}
