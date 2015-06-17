using Game.CharacterClasses;
using Game.Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Game
{
    public static class UI
    {
        //Implement rest of the UI and Menus.
        //We also need to implement a way to save files.
        public static Player Player;

        public static void CreatePlayer(string name, Entity entity)
        {
            UI.Player = new Player(name);
            UI.Player.Character = entity;
        }
        public static Entity CreateEntity(Game.Engine.Player.PlayerClass playerClass, EntityGender entityGender, string name)
        {
            switch (playerClass)
            {
                case Player.PlayerClass.Druid:
                    return new Druid(entityGender, name);
                case Player.PlayerClass.Mage:
                    return new Mage(entityGender, name);
                case Player.PlayerClass.Warrior:
                    return new Warrior(entityGender, name);
                case Player.PlayerClass.Paladin:
                    return new Paladin(entityGender, name);
                default:
                    return new Mage(entityGender, name);
            }
        }
    }
}
