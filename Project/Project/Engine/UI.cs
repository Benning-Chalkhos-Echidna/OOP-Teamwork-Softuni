using Game.CharacterClasses;
using Game.Engine;
using Project;
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
        public static int RoundCount = 0;

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
        public static void Round(Entity engager, Entity target)
        {
            RoundCount++;
            engager.Engage(target);
            target.Health -= engager.Attack;
        }
        public static string RoundOutcome(Entity engager, Entity target)
        {
            string output = string.Empty;
            if (engager is IHeal) output += string.Format("Healer {0} heals {1} for {2} points.",
                engager.Name, target.Name, engager.Attack);
            else if (engager is IDamage) output += string.Format("Damage dealer {0} attacks {1} for {2} points.",
                engager.Name, target.Name, engager.Attack);
            output += string.Format("\n{0} is left with {1} health points.", target.Name, target.Health);
            return output;
        }
    }
}
