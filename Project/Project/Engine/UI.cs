using Project.Engine.Classes;
using Project.Engine.Interfaces;
using System;
using System.Collections.Generic;

namespace Project.Engine
{
    public static class UI
    {
        //Implement rest of the UI and Menus.
        //We also need to implement a way to save files.
        public static Player Player;
        public static int RoundCount = 0;
        public static List<Entity> allEntities = new List<Entity>();
        public static Entity enemyTest = new Warrior(EntityGender.Male, "Enemy", EntityTeam.Enemy);
        public static Random rnd = new Random();

        public static void CreatePlayer(string name, Entity entity)
        {
            UI.Player = new Player(name);
            UI.Player.Character = entity;
            allEntities.Add(entity);
            allEntities.Add(enemyTest);
        }
        public static Entity CreateEntity(Player.PlayerClass playerClass, EntityGender entityGender, string name)
        {
            switch (playerClass)
            {
                case Player.PlayerClass.Druid:
                    return new Druid(entityGender, name, EntityTeam.Player);
                case Player.PlayerClass.Mage:
                    return new Mage(entityGender, name, EntityTeam.Player);
                case Player.PlayerClass.Warrior:
                    return new Warrior(entityGender, name, EntityTeam.Player);
                case Player.PlayerClass.Paladin:
                    return new Paladin(entityGender, name, EntityTeam.Player);
                default:
                    return new Mage(entityGender, name, EntityTeam.Player);
            }
        }
        public static void Round(Entity engager, Entity target)
        {
            RoundCount++;
            if (engager is IHeal) target.Health += engager.Attack;
            else if (engager is IDamage) target.Health -= engager.Attack;
        }
        public static string RoundOutcome(Entity engager, Entity target)
        {
            string output = string.Empty;
            if (engager.Team == EntityTeam.Player)
            {
                if (engager is IHeal)
                    output += string.Format("Player {0} heals Ally {1} for {2} points.", engager.Name, target.Name, engager.Attack);
                else if (engager is IDamage)
                    output += string.Format("Player {0} attacks Enemy {1} for {2} points.", engager.Name, target.Name, engager.Attack);
            }
            else
            {
                if (engager is IHeal)
                    output += string.Format("Healer {0} heals Ally {1} for {2} points.", engager.Name, target.Name, engager.Attack);
                else if (engager is IDamage)
                    output += string.Format("Damage dealer {0} attacks Enemy {1} for {2} points.", engager.Name, target.Name, engager.Attack);
            }
            output += string.Format("\n{0} is left with {1} health points.", target.Name, target.Health);
            return output;
        }

        public static void PassEngagerAndTarget()
        {
            int indexOne = rnd.Next(0, allEntities.Count);
            int indexTwo = rnd.Next(0, allEntities.Count);

            if (allEntities[indexOne].Team == allEntities[indexTwo].Team)
            {
                if (allEntities[indexOne].isAlive == true)
                {
                    if (allEntities[indexOne] is IHeal)
                    {
                        if (allEntities[indexTwo].isAlive == true)
                        {
                            Round(allEntities[indexOne], allEntities[indexTwo]);
                        }
                        else
                            PassEngagerAndTarget();
                    }
                    else
                        PassEngagerAndTarget();
                }
                else
                    PassEngagerAndTarget();
            }
            else
            {
                if (allEntities[indexOne].isAlive == true)
                {
                    if (allEntities[indexOne] is IDamage)
                    {
                        if (allEntities[indexTwo].isAlive == true)
                        {
                            Round(allEntities[indexOne], allEntities[indexTwo]);
                        }
                        else
                            PassEngagerAndTarget();
                    }
                    else
                        PassEngagerAndTarget();
                }
                else
                    PassEngagerAndTarget();
            }
        }
    }
}
