using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameServer.GameCharacters;
using GameServer.Items;

namespace GameServer.BattleCalculator
{

    public static class BattleCalculator
    {
        private static readonly Random _randomElement = new Random();
        private static StringBuilder _stringBuilder = new StringBuilder();
        public static string CalculaterBattleResult(List<Entity> goodGuysList, List<Entity> badGuysList)
        {
            
            bool isGameOver = false; //End batleDeterminat.
            bool isGoodTeamAlife = true;
            bool isBadTeamAlife = true;

            string battleResultresult ="";
            while (!isGameOver)
            {
                //goodGuys always hit first.
                foreach (var goodGuy in goodGuysList)
                {
                    AttackEnemyFromOtherGroup(goodGuy,badGuysList);
                }
                //badGuys hits!
                foreach (var badGuy in badGuysList)
                {
                   AttackEnemyFromOtherGroup(badGuy,goodGuysList);
                }
                foreach (var goodGuy in goodGuysList)
                {
                    isGoodTeamAlife = isGoodTeamAlife || goodGuy.IsAlive;//DEBUG THIS MAY NOT WORK!!!
                    
                }
                foreach (var badGuy in badGuysList)
                {
                    isBadTeamAlife = isBadTeamAlife || badGuy.IsAlive;//SAME
                }
                //isGoodTeamAlife = goodGuysList.Aggregate(isGoodTeamAlife, (current, goodGuy) => current || goodGuy.IsAlive);

                //isBadTeamAlife = badGuysList.Aggregate(isBadTeamAlife, (current, badGuy) => current || badGuy.IsAlive);

                if (!isGoodTeamAlife||!isBadTeamAlife)//SAME
                {
                    isGameOver = true;
                }
                
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
            _stringBuilder.AppendLine(string.Format("{0}get bonus {1} armor from equipmed items",
                player.CreatureName, armorsList.Sum(item=>item.DefenceBonus)));//DEBUG! 
            
        }

        public static void SetAttackBonusStats(Player player, Weapon weapon)
        {
            player.CalckAttackBonusStats(weapon);
            _stringBuilder.AppendLine(string.Format("{0}get bonus {1} attack from {2}", //DEBUG
                player.CreatureName, weapon.AttackBonus, weapon.ItemName));
        }


        private static void AttackEnemyFromOtherGroup(Entity entity,List<Entity> entitiesList )
        {
            int cshosedTargerIndex;
            do
            {
                cshosedTargerIndex = _randomElement.Next(0, entitiesList.Count-1);
                System.Threading.Thread.Sleep(1);//SAME RANDOM SEED BUGS!!
            } while (entitiesList[cshosedTargerIndex].IsAlive);
          
           var attackPower = (entitiesList[cshosedTargerIndex].DefencePoints -entity.AttackPoints);
            if (attackPower<=0)
            {
                attackPower = 1;
            }
            entitiesList[cshosedTargerIndex].HealtPoint = (entitiesList[cshosedTargerIndex].HealtPoint - attackPower);
            _stringBuilder.AppendLine(string.Format("{0} attack {1} for {2} point life!",
                entity.CreatureName,entitiesList[cshosedTargerIndex].CreatureName,attackPower));                                               
            if (entitiesList[cshosedTargerIndex].HealtPoint<=0)
            {
                entitiesList[cshosedTargerIndex].IsAlive = false;
            }
        }
       
    }
}

