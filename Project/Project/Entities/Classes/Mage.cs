using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities.Classes
{
    public class Mage : Player
    {
        private const int MageAgility = 10;
        private const int MageStrength = 10;
        private const int MageIntelligence = 30;
        public Mage(string name)
            : base(name, MageAgility, MageStrength, MageIntelligence)
        {
            
        }
        public Mage(string name, int agi, int str, int intel)
            : base(name, agi, str, intel)
        {
            Name = name;
            Agi = agi;
            Str = str;
            Intel = intel;
        }
    }
}
