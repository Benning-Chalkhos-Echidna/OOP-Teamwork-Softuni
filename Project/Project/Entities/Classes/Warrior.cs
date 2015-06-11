using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class Warrior : Player
    {
        private const int WarriorAgility = 10;
        private const int WarriorStrength = 30;
        private const int WarriorIntelligence = 10;
        public Warrior(string name, int agi, int str, int intel)
            : base(name, WarriorAgility, WarriorStrength, WarriorIntelligence)
        {
            base.Intel = intel;
            base.Agi = agi;
            base.Str = str;
        }
    }
}
