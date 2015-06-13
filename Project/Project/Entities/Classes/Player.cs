using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities.Classes
{
    public abstract class Player : Entity
    {
        //Intellect - Defines Mana
        private int intel;
        public int Intel
        {
            get { return intel; }
            set { intel = value; }
        }

        private int mana;
        public int Mana
        {
            get
            {
                return (Intel * 2) + 50;
            }
        }

        //For each level - stats bonuses (idk)
        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        protected Player(string name, int agi, int str, int intel)
        {
            Name = name;
        }
    }
}
