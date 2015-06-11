﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
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
                return (this.Intel * 2) + 50;
            }
        }

        //For each level - stats bonuses (idk)
        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public Player(string name, int agi, int str, int intel)
        {
            base.Name = name;
        }
    }
}
