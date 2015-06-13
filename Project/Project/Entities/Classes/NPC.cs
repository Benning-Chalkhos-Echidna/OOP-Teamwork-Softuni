using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities.Classes
{
    public abstract class NPC : Entity
    {
        protected NPC(string name, int hp, int agi, int str)
        {
            Name = name;
            Agi = agi;
            Str = str;
        }
    }
}
