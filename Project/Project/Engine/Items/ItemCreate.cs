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
        private static readonly Dictionary<string, string[]> ItemsMap = 
            new Dictionary<string, string[]>
        {
            {"HeadGear", File.ReadAllLines(@"..\..\Resources\headgear.txt")},
            {"ChestGear", File.ReadAllLines(@"..\..\Resources\chestgear.txt")},
            {"HandsGear", File.ReadAllLines(@"..\..\Resources\handsgear.txt")},
            {"LegsGear", File.ReadAllLines(@"..\..\Resources\legsgear.txt")},
            {"Weapon", File.ReadAllLines(@"..\..\Resources\weapons.txt")}
        };

        public static Item GetRandomItem(string type)
        {
            Random rand = new Random();
            
            var itemList = ItemsMap[type];
            var randomLine = itemList[rand.Next(itemList.Length)];
            string[] itemSplit = Regex.Split(randomLine, "\\s+");
            
            long id = long.Parse(itemSplit[0]);
            string name = itemSplit[1].Replace('_', ' ');
            int str = int.Parse(itemSplit[2]);
            int agi = int.Parse(itemSplit[3]);
            int intel = int.Parse(itemSplit[4]);
            int hp = int.Parse(itemSplit[5]);
            
            if (type == "HeadGear")
            {
                return new HeadGear(id, name, str, agi, intel, hp);
            }
            if (type == "ChestGear")
            {
                return new ChestGear(id, name, str, agi, intel, hp);
            }
            if (type == "HandsGear")
            {
                return new HandsGear(id, name, str, agi, intel, hp);
            }
            if (type == "LegsGear")
            {
                return new LegsGear(id, name, str, agi, intel, hp);
            }
            if (type == "Weapon")
            {
                return new Weapon(id, name, str, agi, intel, hp);
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
            string name = itemSplit[1].Replace('_', ' ');
            int str = int.Parse(itemSplit[2]);
            int agi = int.Parse(itemSplit[3]);
            int intel = int.Parse(itemSplit[4]);
            int hp = int.Parse(itemSplit[5]);
            
            if (itemSplit[0].Length < 4)
            {
                return new HeadGear(id,name,str,agi,intel,hp);
            }
            if (itemSplit[0].Length == 4)
            {
                return new ChestGear(id,name,str,agi,intel,hp);
            }
            if (itemSplit[0].Length == 5)
            {
                return new HandsGear(id,name,str,agi,intel,hp);
            }
            if (itemSplit[0].Length == 6)
            {
                return new LegsGear(id,name,str,agi,intel,hp);
            }
            if (itemSplit[0].Length == 7)
            {
                return new Weapon(id,name,str,agi,intel,hp);
            }

            throw new InvalidItemException("Item creation error!");
        }
    }
}
