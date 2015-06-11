using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class Hunter : Player
    {
        public Hunter(string name, int agi, int str, int intel)
            : base(name, 30, 10, 10)
        {
            base.Intel = intel;
            base.Agi = agi;
            base.Str = str;
        }
    }
}
