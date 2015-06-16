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
        private Dictionary<int, Entity> characters;
        private string username;
        private string password;
        private Entity chosenCharacter;

        public Player(string username, string password)
        {
            this.Username = username;
            this.Password = password;

            this.Characters = new Dictionary<int, Entity>();
        }

        public string Username
        {
            get { return this.username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length == 0) throw new Exception("Username cannot be empty field!");
                else if (value.Length > 15) throw new Exception("Username cannot be larger than 15 characters!");
                else this.username = value;
            }
        }
        public string Password
        {
            get { return this.password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length == 0) throw new Exception("Password cannot be empty field!");
                else if (value.Length > 15) throw new Exception("Password cannot be larger than 15 characters!");
                else this.password = value;
            }
        }
        public Dictionary<int, Entity> Characters
        {
            get { return this.characters; }
            set { this.characters = value; }
        }

        public Entity Character
        {
            get { return this.chosenCharacter; }
            set { this.chosenCharacter = value; }
        }
        public void setCharacter(Entity character)
        {
            this.Character = character;
        }
    }
}
