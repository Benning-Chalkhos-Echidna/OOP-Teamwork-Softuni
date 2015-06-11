using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class Mage : Player
    {
        public Mage(string name, int agi, int str, int intel)
            : base(name, 10, 10, 30)
        {
            base.Intel = intel;
            base.Agi = agi;
            base.Str = str;
        }
    }
}
