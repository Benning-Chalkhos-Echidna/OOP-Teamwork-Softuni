using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Project.Engine.Exceptions;

namespace Project.Engine.Items
{
    public class ItemCreate
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
            string[] itemSplit = Regex.Split(randomLine, "\\s+");
            
            long id = long.Parse(itemSplit[0]);
            string subtype = itemSplit[1];
            string name = itemSplit[2].Replace('_', ' ');
            int str = int.Parse(itemSplit[3]);
            int agi = int.Parse(itemSplit[4]);
            int intel = int.Parse(itemSplit[5]);
            int hp = int.Parse(itemSplit[6]);
            
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
        
        public static Item GetRandomItem()
        {
            Random rand = new Random();

            var randomCategory = ItemsMap.ElementAt(rand.Next(0, ItemsMap.Count)).Value;
            var randomLine = randomCategory[rand.Next(randomCategory.Length)];
            string[] itemSplit = Regex.Split(randomLine, "\\s+");
            
            long id = long.Parse(itemSplit[0]);
            string subtype = itemSplit[1];
            string name = itemSplit[2].Replace('_', ' ');
            int str = int.Parse(itemSplit[3]);
            int agi = int.Parse(itemSplit[4]);
            int intel = int.Parse(itemSplit[5]);
            int hp = int.Parse(itemSplit[6]);
            
            if (itemSplit[0].Length < 4)
            {
                return new HeadGear(id,subtype,name,str,agi,intel,hp);
            }
            if (itemSplit[0].Length == 4)
            {
                return new ChestGear(id, subtype, name, str, agi, intel, hp);
            }
            if (itemSplit[0].Length == 5)
            {
                return new HandsGear(id, subtype, name, str, agi, intel, hp);
            }
            if (itemSplit[0].Length == 6)
            {
                return new LegsGear(id, subtype, name, str, agi, intel, hp);
            }
            if (itemSplit[0].Length == 7)
            {
                return new Weapon(id, subtype, name, str, agi, intel, hp);
            }

            throw new InvalidItemException("Item creation error!");
        }
    }
}
