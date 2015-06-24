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
        public static Entity enemyTest = new Warrior(EntityGender.Male, "Enemy", EntityTeam.Enemy);
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
            gameType = GameType.TwoVsTwo;
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
        public static void Round(Entity engager, Entity target)
        {
            RoundCount++;
            if (engager is IHeal) target.Health += engager.Attack;
            else if (engager is IDamage) target.Health -= engager.Attack;
            if (target.Health < 0) target.isAlive = false;
            UI.updateAllies.Invoke();
            UI.updateEnemies.Invoke();

        }
        public static string RoundOutcome(Entity engager, Entity target)
        {
            string output = string.Empty;
            if (target.isAlive == true)
            {
                if (engager.isAlive == true)
                {
                    if (engager.Team == EntityTeam.Player)
                    {
                        if (engager is IHeal)
                            output += string.Format("Player {0} heals Ally {1} for {2} points.", engager.Name, target.Name, engager.Attack);
                        else if (engager is IDamage)
                            output += string.Format("Player {0} attacks Enemy {1} for {2} points.", engager.Name, target.Name, engager.Attack);
                    }
                    else if (engager.Team == EntityTeam.Ally)
                    {
                        if (engager is IHeal)
                            output += string.Format("Your allied healer {0} heals {1} for {2} health points.",
                                engager.Name, target.Name, engager.Attack);
                        else if (engager is IDamage)
                            output += string.Format("Your allied damage dealer {0} attacks {1} for {2} health points.",
                                engager.Name, target.Name, engager.Attack);
                    }
                    else if (engager.Team == EntityTeam.Enemy)
                    {
                        if (engager is IHeal)
                            output += string.Format("Enemy healer {0} heals his ally {1} for {2} health points.",
                                engager.Name, target.Name, engager.Attack);
                        else if (engager is IDamage)
                            output += string.Format("Enemy damage dealer {0} attacks {1} for {2} health points.",
                                engager.Name, target.Name, engager.Attack);
                    }
                    if (target.isAlive == true)
                    {
                        output += string.Format("\n{0} is left with {1} health points.", target.Name, target.Health);
                        return output;
                    }
                    else
                    {
                        output += string.Format("\n{0} has been slain!", target.Name);
                        
                    }
                }
            }
            return output;
        }

        /*public static void PassEngagerAndTarget()
        { 
         * re-implemented with GenerateEnemiesAndAllies();
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
         */
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
                        newEnemyEntity = new Paladin(EntityGender.Female, "PaladinLady", EntityTeam.Enemy);
                        Enemies.Add(newEnemyEntity);
                        allEntities.Add(newEnemyEntity);
                        break;
                }
            }
        }
    }
}
