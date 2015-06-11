using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public abstract class Entity
    {
        //Entity Life and Mana
        private int hp;
        public int HP
        {
            get { return ((this.str + this.agi) * 3) + 500; }
        }

        //Entity Details
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Entity Stats
        //Agility - Defines Attack Speed;
        private int agi;
        public int Agi
        {
            get { return agi; }
            set { agi = value; }
        }

        //Strength - Defines Damage
        private int str;
        public int Str
        {
            get { return str; }
            set { str = value; }
        }

        public int AttackSpeed
        {
            get
            {
                return (this.agi*2) + 50;
            }
        }
        public int Damage
        {
            get
            {
                return (this.str * 2) + 50;
            }
        }
    }
}
