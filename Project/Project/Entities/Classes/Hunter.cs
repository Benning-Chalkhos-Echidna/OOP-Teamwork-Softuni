using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class Hunter : Player
    {
        private const int HunterAgility = 30;
        private const int HunterStrength = 10;
        private const int HunterIntelligence = 10;

        public Hunter(string name, int agi, int str, int intel)
            : base(name, HunterAgility, HunterStrength, HunterIntelligence)
        {
            base.Intel = intel;
            base.Agi = agi;
            base.Str = str;
        }
    }
}
