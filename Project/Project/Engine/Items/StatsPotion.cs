﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class StatsPotion : Consumable
    {
        public StatsPotion(long id, string name, int str, int agi, int intel, int hp, int charges)
            : base(id, name, str, agi, intel, hp, charges)
        {
            
        }
    }
}
