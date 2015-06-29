using Project.Engine.Classes;
using Project.Engine.Form;
using Project.Engine.Interfaces;
using System;
using System.Collections.Generic;

namespace Project.Engine
{
    public enum GameType { FourVsFour, ThreeVsThree, TwoVsTwo, OneVsOne }
    public static class UI
    {
        public static int roundCounter = 1;
        public static GameType gameType; //TODO: Set value;
        //Implement rest of the UI and Menus.
        //We also need to implement a way to save files.
        public static Player Player;
        public static int RoundCount = 0;
        public static Random rnd = new Random();

        public static List<Entity> allEntities = new List<Entity>();
        public static List<Entity> Allies = new List<Entity>();
        public static List<Entity> Enemies = new List<Entity>();

        public static Action updateAllies;
        public static Action updateEnemies;

        public static void CreatePlayer(string name, Entity entity)
        {
            UI.Player = new Player(name);
            UI.Player.Character = entity;
            allEntities.Add(entity);
            GenerateEnemiesAndAllies();
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

        public static string HandleSpell(IEntity engager, IEntity target)
        {
            return string.Empty;
        }
        public static string HandleAttack(IEntity engager, IEntity target)
        {
            string output = string.Empty;

            if (engager.Attack > 0)
            {
                if (engager.isAlive)
                {
                    if (target.isAlive)
                    {
                        int attVal = engager.Attack - target.Defense + UI.rnd.Next(1, 10);
                        target.Health -= attVal;
                        if (target.Health <= 0)
                        {
                            target.isAlive = false;
                            output += string.Format("{0} has been slain by {1}!", target.Name, engager.Name);
                        }
                        else
                        {
                            output += string.Format("{0} attacked {1} for {2} damage! {1} is left with {3} health points!",
                                engager.Name, target.Name, attVal, target.Health);
                        }
                    }
                    else
                    {
                        output += string.Format("{0} is dead.", target.Name);
                    }
                }
                else
                {
                    output += string.Format("{0} is dead.", engager.Name);
                }
            }
            else
            {
                output += string.Format("{0} cannot attack!", engager.Name);
            }
            UI.updateAllies();
            UI.updateEnemies();
            return output;
        }
        private static void GenerateEnemiesAndAllies()
        {
            int allyCount = 0;
            int enemyCount = 0;
            switch (UI.gameType)
            {
                case GameType.FourVsFour:
                    allyCount = 3;
                    enemyCount = 4;
                    break;
                case GameType.ThreeVsThree:
                    allyCount = 2;
                    enemyCount = 3;
                    break;
                case GameType.TwoVsTwo:
                    allyCount = 1;
                    enemyCount = 2;
                    break;
                case GameType.OneVsOne:
                    allyCount = 0;
                    enemyCount = 1;
                    break;
            }

            int classVal = rnd.Next(1, 5);
            for (int i = 0; i < allyCount; i++)
            {
                classVal = rnd.Next(1, 5);
                Entity newAllyEntity;
                switch (classVal)
                {
                    //Mage
                    case 1:
                        newAllyEntity = new Mage(EntityGender.Female, "Jaina Proudmoore", EntityTeam.Ally);
                        Allies.Add(newAllyEntity);
                        allEntities.Add(newAllyEntity);
                        break;
                    //Warrior
                    case 2:
                        newAllyEntity = new Warrior(EntityGender.Male, "Arthas", EntityTeam.Ally);
                        Allies.Add(newAllyEntity);
                        allEntities.Add(newAllyEntity);
                        break;
                    //Druid
                    case 3:
                        newAllyEntity = new Druid(EntityGender.Male, "Threant Protector", EntityTeam.Ally);
                        Allies.Add(newAllyEntity);
                        allEntities.Add(newAllyEntity);
                        break;
                    //Paladin
                    case 4:
                        newAllyEntity = new Paladin(EntityGender.Male, "Uther", EntityTeam.Ally);
                        Allies.Add(newAllyEntity);
                        allEntities.Add(newAllyEntity);
                        break;
                }
            }
            for (int i = 0; i < enemyCount; i++)
            {
                classVal = rnd.Next(1, 5);
                Entity newEnemyEntity;
                switch (classVal)
                {
                    //Mage
                    case 1:
                        newEnemyEntity = new Mage(EntityGender.Female, "Dark Mage", EntityTeam.Enemy);
                        Enemies.Add(newEnemyEntity);
                        allEntities.Add(newEnemyEntity);
                        break;
                    //Warrior
                    case 2:
                        newEnemyEntity = new Warrior(EntityGender.Male, "Barbarian", EntityTeam.Enemy);
                        Enemies.Add(newEnemyEntity);
                        allEntities.Add(newEnemyEntity);
                        break;
                    //Druid
                    case 3:
                        newEnemyEntity = new Druid(EntityGender.Male, "Furion", EntityTeam.Enemy);
                        Enemies.Add(newEnemyEntity);
                        allEntities.Add(newEnemyEntity);
                        break;
                    //Paladin
                    case 4:
                        newEnemyEntity = new Paladin(EntityGender.Female, "Paladin Lady", EntityTeam.Enemy);
                        Enemies.Add(newEnemyEntity);
                        allEntities.Add(newEnemyEntity);
                        break;
                }
            }
        }
    }
}
