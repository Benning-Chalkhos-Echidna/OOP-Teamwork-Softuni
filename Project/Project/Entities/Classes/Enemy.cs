using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities.Classes
{
    public class Enemy : NPC
    {

        public Enemy(string name, int hp, int agi, int str) : base(name,hp,agi,str)
        {
            Name = name;
            Agi = agi;
            Str = str;
        }
    }
}
