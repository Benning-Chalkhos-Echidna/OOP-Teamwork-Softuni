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
        private static readonly string[] HeadGearTxt =
                File.ReadAllLines(@"..\..\Resources\headgear.txt");
        
        private static readonly string[] ChestGearTxt = 
            File.ReadAllLines(@"..\..\Resources\chestgear.txt");

        private static readonly string[] HandsGearTxt = 
            File.ReadAllLines(@"..\..\Resources\handsgear.txt");

        private static readonly string[] LegsGearTxt = 
            File.ReadAllLines(@"..\..\Resources\legsgear.txt");

        private static readonly string[] WeaponsTxt = 
            File.ReadAllLines(@"..\..\Resources\weapons.txt");

        private static Dictionary<Type,string[]> ItemsMap = new Dictionary<Type, string[]>
        {
            {typeof(HeadGear),HeadGearTxt},
            {typeof(ChestGear),ChestGearTxt},
            {typeof(HandsGear), HandsGearTxt},
            {typeof(LegsGear),LegsGearTxt},
            {typeof(Weapon),WeaponsTxt}
        }; 
        
        public static Item GetRandomItem()
        {
            Random rand = new Random();
            ItemsMap = ItemsMap.OrderBy(x => rand.Next())
                .ToDictionary(item => item.Key, item => item.Value);

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
