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
            base.Name = name;
            base.Agi = agi;
            base.Str = str;
        }
    }
}
