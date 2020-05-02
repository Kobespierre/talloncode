using System;
using System.Collections.Generic;

namespace FinalFantasyAPI.Context
{
    public partial class JobArmor
    {
        public long? JobId { get; set; }
        public long? ArmorId { get; set; }

        public virtual Armor Armor { get; set; }
        public virtual Job Job { get; set; }
    }
}
