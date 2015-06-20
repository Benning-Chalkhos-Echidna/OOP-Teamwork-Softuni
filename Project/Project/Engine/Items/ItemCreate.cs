using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Project.Engine.Exceptions;

namespace Project.Engine.Items
{
    public class ItemCreate
    {
        private static readonly string[] headGearTxt =
                File.ReadAllLines(@"..\..\Resources\headgear.txt");
        
        private static readonly string[] chestGearTxt = 
            File.ReadAllLines(@"..\..\Resources\chestgear.txt");

        private static readonly string[] handsGearTxt = 
            File.ReadAllLines(@"..\..\Resources\handsgear.txt");

        private static readonly string[] legsGearTxt = 
            File.ReadAllLines(@"..\..\Resources\legsgear.txt");

        private static readonly string[] weaponsTxt = 
            File.ReadAllLines(@"..\..\Resources\weapons.txt");
        
        public static Item GetRandomItem()
        {
            Item randomItem;
            var mergedItemsTxt = new List<String[]>
            {
                headGearTxt,
                chestGearTxt,
                handsGearTxt,
                legsGearTxt,
                weaponsTxt
            };
            Random r = new Random();
            var randomCategory = mergedItemsTxt[r.Next(mergedItemsTxt.Count)];
            var randomLine = randomCategory[r.Next(randomCategory.Length)];
            string[] itemSplit = Regex.Split(randomLine, "\\s+");
            if (itemSplit[0].Length < 4)
            {
                randomItem = new HeadGear
                    (long.Parse(itemSplit[0]),itemSplit[1].Replace('_', ' '),
                        int.Parse(itemSplit[2]),int.Parse(itemSplit[3]), int.Parse(itemSplit[4]),
                        int.Parse(itemSplit[5]));
                return (HeadGear)randomItem;
            }
            if (itemSplit[0].Length == 4)
            {
                randomItem = new ChestGear
                    (long.Parse(itemSplit[0]), itemSplit[1].Replace('_', ' '),
                        int.Parse(itemSplit[2]), int.Parse(itemSplit[3]), int.Parse(itemSplit[4]),
                        int.Parse(itemSplit[5]));
                return (ChestGear)randomItem;
            }
            if (itemSplit[0].Length == 5)
            {
                randomItem = new HandsGear
                    (long.Parse(itemSplit[0]), itemSplit[1].Replace('_', ' '),
                        int.Parse(itemSplit[2]), int.Parse(itemSplit[3]), int.Parse(itemSplit[4]),
                        int.Parse(itemSplit[5]));
                return (HandsGear)randomItem;
            }
            if (itemSplit[0].Length == 6)
            {
                randomItem = new LegsGear
                    (long.Parse(itemSplit[0]), itemSplit[1].Replace('_', ' '),
                        int.Parse(itemSplit[2]), int.Parse(itemSplit[3]), int.Parse(itemSplit[4]),
                        int.Parse(itemSplit[5]));
                return (LegsGear)randomItem;
            }
            if (itemSplit[0].Length == 7)
            {
                randomItem = new Weapon
                    (long.Parse(itemSplit[0]), itemSplit[1].Replace('_', ' '),
                        int.Parse(itemSplit[2]), int.Parse(itemSplit[3]), int.Parse(itemSplit[4]),
                        int.Parse(itemSplit[5]));
                return (Weapon)randomItem;
            }

            throw new InvalidItemException("Item creation error!");
        }
    }
}
