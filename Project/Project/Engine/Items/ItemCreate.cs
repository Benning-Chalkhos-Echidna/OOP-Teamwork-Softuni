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
                ItemListsPath)))}
        };

        public static Item GetRandomItem(string type)
        {
            Random rand = new Random();
            
            var itemList = ItemsMap[type];
            var randomLine = itemList[rand.Next(itemList.Length)];
            var returnStats = ReturnStats(randomLine);
            return ReturnItem(type, (long)returnStats[0], (string)returnStats[1], 
                (string)returnStats[2], (int)returnStats[3], (int)returnStats[4], 
                (int)returnStats[5], (int)returnStats[6]);
        }
        
        public static Item GetRandomItem()
        {
            Random rand = new Random();

            var randomCategory = ItemsMap.ElementAt(rand.Next(0, ItemsMap.Count));
            var randomCategoryList = randomCategory.Value;
            var randomLine = randomCategoryList[rand.Next(randomCategoryList.Length)];
            var returnStats = ReturnStats(randomLine);
            return ReturnItem(randomCategory.Key, (long)returnStats[0], (string)returnStats[1],
                (string)returnStats[2], (int)returnStats[3], (int)returnStats[4],
                (int)returnStats[5], (int)returnStats[6]);
        }

        private static Item ReturnItem
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

            throw new InvalidItemException("Item creation error!");
        }

        private static List<object> ReturnStats(string line)
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
    }
}