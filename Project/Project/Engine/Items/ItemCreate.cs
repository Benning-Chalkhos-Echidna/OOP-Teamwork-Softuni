using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Project.Engine.Exceptions;

namespace Project.Engine.Items
{
    public static class ItemCreate
    {
        private static Random rand = new Random();
        private const string ItemListsPath = @"..\..\Resources\item_lists\";
        private static readonly Dictionary<string, string[]> ItemsMap = 
            new Dictionary<string, string[]>
        {
            {"HeadGear", File.ReadAllLines(Path.GetFullPath(string.Format("{0}headgear.txt",
                ItemListsPath)))},
            {"ChestGear", File.ReadAllLines(Path.GetFullPath(string.Format("{0}chestgear.txt",
                ItemListsPath)))},
            {"HandsGear", File.ReadAllLines(Path.GetFullPath(string.Format("{0}handsgear.txt",
                ItemListsPath)))},
            {"LegsGear", File.ReadAllLines(Path.GetFullPath(string.Format("{0}legsgear.txt",
                ItemListsPath)))},
            {"Weapon", File.ReadAllLines(Path.GetFullPath(string.Format("{0}weapons.txt",
                ItemListsPath)))},
            {"HealthPotion",File.ReadAllLines(Path.GetFullPath(string.Format("{0}healthpotions.txt",
                ItemListsPath)))},
            {"StatsPotion",File.ReadAllLines(Path.GetFullPath(string.Format("{0}statspotions.txt",
                ItemListsPath)))}
        };

        public static Item GetRandomItem(string type = null)
        {
            string[] categoryList;
            if (type == null)
            {
                var category = ItemsMap.ElementAt(rand.Next(ItemsMap.Count));
                type = category.Key;
                categoryList = category.Value;
            }
            else
            {
                categoryList = ItemsMap[type];
            }
            var randomLine = categoryList[rand.Next(categoryList.Length)];
            if (type != "HealthPotion" && type != "StatsPotion") // too explicit right now
            {
                var returnStats = ReturnEquipableStats(randomLine);
                return ReturnEquipableItem(type, (long) returnStats[0], (string) returnStats[1],
                    (string) returnStats[2], (int) returnStats[3], (int) returnStats[4],
                    (int) returnStats[5], (int) returnStats[6]);
            }
            else
            {
                var returnStats = ReturnConsumableStats(randomLine);
                return ReturnConsumableItem(type, (long)returnStats[0], (string)returnStats[1],
                    (string)returnStats[2], (int)returnStats[3], (int)returnStats[4],
                    (int)returnStats[5], (int)returnStats[6], (int)returnStats[7]);
            }
        }

        private static Item ReturnEquipableItem
            (string type, long id, string subtype, string name, int str, int agi, int intel, int hp)
        {
            if (type == "HeadGear")
            {
                return new HeadGear(id, subtype, name, str, agi, intel, hp);
            }
            if (type == "ChestGear")
            {
                return new ChestGear(id, subtype, name, str, agi, intel, hp);
            }
            if (type == "HandsGear")
            {
                return new HandsGear(id, subtype, name, str, agi, intel, hp);
            }
            if (type == "LegsGear")
            {
                return new LegsGear(id, subtype, name, str, agi, intel, hp);
            }
            if (type == "Weapon")
            {
                return new Weapon(id, subtype, name, str, agi, intel, hp);
            }

            throw new InvalidItemException("Equipable item creation error!");
        }

        private static Item ReturnConsumableItem
            (string type, long id, string subtype, string name, int str, int agi,
                int intel, int hp, int charges)
        {
            if (type == "HealthPotion")
            {
                return new HealthPotion(id, subtype,name,str,agi,intel,hp,charges);
            }
            if (type == "StatsPotion")
            {
                return new StatsPotion(id, subtype,name,str,agi,intel,hp,charges);
            }
            throw new InvalidItemException("Consumable item creation error!");
        }

        private static List<object> ReturnEquipableStats(string line)
        {
            string[] itemSplit = Regex.Split(line, "\\s+");
            long id = long.Parse(itemSplit[0]);
            string subtype = itemSplit[1];
            string name = itemSplit[2].Replace('_', ' ');
            int str = int.Parse(itemSplit[3]);
            int agi = int.Parse(itemSplit[4]);
            int intel = int.Parse(itemSplit[5]);
            int hp = int.Parse(itemSplit[6]);
            var returnList = new List<object>{id,subtype,name,str,agi,intel,hp};
            return returnList;
        }

        private static List<object> ReturnConsumableStats(string line)
        {
            string[] itemSplit = Regex.Split(line, "\\s+");
            long id = long.Parse(itemSplit[0]);
            string subtype = itemSplit[1];
            string name = itemSplit[2].Replace('_', ' ');
            int str = int.Parse(itemSplit[3]);
            int agi = int.Parse(itemSplit[4]);
            int intel = int.Parse(itemSplit[5]);
            int hp = int.Parse(itemSplit[6]);
            int charges = int.Parse(itemSplit[7]);
            var returnList = new List<object> { id, subtype, name, str, agi, intel, hp, charges };
            return returnList;
        } 
    }
}