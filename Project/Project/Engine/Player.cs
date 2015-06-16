using Game.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine
{
    public class Player
    {
        public enum PlayerClass { Warrior, Mage, Paladin, Druid }
        private string username;
        private Entity chosenCharacter;

        public Player(string username)
        {
            this.Username = username;
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public Entity Character
        {
            get { return this.chosenCharacter; }
            set { this.chosenCharacter = value; }
        }
    }
}
