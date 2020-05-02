using System;
using System.Collections.Generic;

namespace FinalFantasyAPI.Context
{
    public partial class Weapon
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Damage { get; set; }
        public long Hit { get; set; }
    }
}
