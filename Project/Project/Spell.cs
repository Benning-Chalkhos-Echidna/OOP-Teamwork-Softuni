﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public enum SpellType { HealSpell, DamageSpell }
    public class Spell
    {
        private SpellType spellType;
        private int spellVal;

        public Spell(SpellType spellType)
        {
            this.TypeOfSpell = spellType;
            this.SpellVal = 0;
        }

        public SpellType TypeOfSpell
        {
            get { return this.spellType; }
            set { this.spellType = value; }
        }

        public int SpellVal
        {
            get { return this.spellVal; }
            set { this.spellVal = value; }
        }
    }
}
