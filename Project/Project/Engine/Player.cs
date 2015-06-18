using Project.Engine.Classes;

namespace Project.Engine
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
