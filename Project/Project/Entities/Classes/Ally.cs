using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class Ally : NPC
    {
        public Ally(string name, int hp, int agi, int str) : base(name,hp,agi,str)
        {
            base.Name = name;
            base.Agi = agi;
            base.Str = str;
        }
    }
}
