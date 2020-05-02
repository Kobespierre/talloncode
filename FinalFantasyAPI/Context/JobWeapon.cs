using System;
using System.Collections.Generic;

namespace FinalFantasyAPI.Context
{
    public partial class JobWeapon
    {
        public long? JobId { get; set; }
        public long? WeaponId { get; set; }

        public virtual Job Job { get; set; }
        public virtual Weapon Weapon { get; set; }
    }
}
