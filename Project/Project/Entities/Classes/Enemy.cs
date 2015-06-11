using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class Enemy : NPC
    {

        public Enemy(string name, int hp, int agi, int str)
        {
            base.Name = name;
            base.Agi = agi;
            base.Str = str;
        }
    }
}
