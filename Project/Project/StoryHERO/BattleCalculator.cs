using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.GameCharacters;
using Project.Items;

namespace Project.StoryHERO
{

    public static class BattleCalculator
    {
        private static readonly Random RandomElement = new Random();
        private static readonly StringBuilder StringBuilder = new StringBuilder();
        
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

        
        public static void SetArmorBonusStats(Player player, List<Armor> armorsList)
        {
            player.CalcDeffenceBonusStats(armorsList);
            StringBuilder.AppendLine(string.Format("{0}get bonus {1} armor from equipmed items",
                player.CreatureName, armorsList.Sum(item=>item.DefenceBonus)));//DEBUG! 
            
        }

        public static void SetAttackBonusStats(Player player, Weapon weapon)
        {
            player.CalckAttackBonusStats(weapon);
            StringBuilder.AppendLine(string.Format("{0}get bonus {1} attack from {2}", //DEBUG
                player.CreatureName, weapon.AttackBonus, weapon.ItemName));
        }


        private static void AttackEnemyFromOtherGroup(Entity entity,List<Entity> entitiesList )
        {
            int cshosedTargerIndex;
            do
            {
                cshosedTargerIndex = RandomElement.Next(0, entitiesList.Count-1);
                System.Threading.Thread.Sleep(1);//SAME RANDOM SEED BUGS!!
            } while (entitiesList[cshosedTargerIndex].IsAlive);
          
           var attackPower = (entitiesList[cshosedTargerIndex].DefencePoints -entity.AttackPoints);
            if (attackPower<=0)
            {
                attackPower = 1;
            }
            entitiesList[cshosedTargerIndex].HealtPoint = (entitiesList[cshosedTargerIndex].HealtPoint - attackPower);
            StringBuilder.AppendLine(string.Format("{0} attack {1} for {2} point life!",
                entity.CreatureName,entitiesList[cshosedTargerIndex].CreatureName,attackPower));                                               
            if (entitiesList[cshosedTargerIndex].HealtPoint<=0)
            {
                entitiesList[cshosedTargerIndex].IsAlive = false;
            }
        }
    }
}

