using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities.Classes
{
    public abstract class Entity
    {
        //Entity Life and Mana
        private int hp;
        public int HP
        {
            get { return ((str + agi) * 3) + 500; }
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
                return (agi*2) + 50;
            }
        }
        public int Damage
        {
            get
            {
                return (str * 2) + 50;
            }
        }
    }
}
