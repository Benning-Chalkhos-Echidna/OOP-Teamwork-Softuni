using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities.Classes
{
    public class Hunter : Player
    {
        private const int HunterAgility = 30;
        private const int HunterStrength = 10;
        private const int HunterIntelligence = 10;

        public Hunter(string name)
            : base(name, HunterAgility, HunterStrength, HunterIntelligence)
        {
            
        }
        public Hunter(string name, int agi, int str, int intel)
            : base(name, agi, str, intel)
        {
            base.Name = name;
            base.Agi = agi;
            base.Str = str;
            base.Intel = intel;
        }
    }
}
