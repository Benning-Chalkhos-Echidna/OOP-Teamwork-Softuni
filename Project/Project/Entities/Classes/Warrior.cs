using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class Warrior : Player
    {
        public Warrior(string name, int agi, int str, int intel)
            : base(name, 10, 30, 10)
        {
            base.Intel = intel;
            base.Agi = agi;
            base.Str = str;
        }
    }
}
