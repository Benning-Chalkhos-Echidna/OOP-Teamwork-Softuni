using System;
using System.Collections.Generic;
using System.Linq;
using GameServer.GameCharacters;
using GameServer.Items;

namespace GameServer.BattleCalculator
{

    public static class BattleCalculator
    {
        private static Random _randomElement = new Random();

        public static string CalculaterBurulResult(List<Entity> goodGuysList, List<Entity> badGuysList)
        {
            bool isGameOver = false; //End batleDeterminat.
            string battleResultresult ="";
            while (!isGameOver)
            {
                //goodGuys always hit first.
                
            }















            return battleResultresult;

        }

        private static List<Entity> GetGoodGuysList(Player player, Ally ally)
        {
            List<Entity> goodGuys = new List<Entity> {player, ally};
            return goodGuys;
        }

        public static void SetArmorBonusStats(Player player, List<Armor> armorsList)
        {
            player.CalcDeffenceBonusStats(armorsList);
        }

        public static void SetAttackBonusStats(Player player, Weapon weapon)
        {
            player.CalckAttackBonusStats(weapon);
        }

        private static void AttackEnemyFromOtherGroup(Entity entity,List<Entity> entitiesList )
        {
            int cshosedTargerIndex = _randomElement.Next(0, entitiesList.Count);
        }
       
    }
}

