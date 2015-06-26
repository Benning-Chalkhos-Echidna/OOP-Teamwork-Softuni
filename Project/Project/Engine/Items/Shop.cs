using System;
using System.Collections.Generic;

namespace Project.Engine.Items
{
    public class Shop
    {
        //private static List<Item> shopItems;

        public List<Item> ShopItems { get; set; }

        public Shop()   // default number of items is 40 for now
        {
            this.ShopItems = new List<Item>();

            Fill("Weapon",9);
            Fill("HandsGear",5);
            Fill("LegsGear",4);
            Fill("ChestGear",5);
            Fill("HeadGear",7);
            Fill("HealthPotion",7);
            Fill("StatsPotion",3);
            
            //Shuffle(this.ShopItems);
        }

        public void ItemBought(int index)   // event should connect Entity.BuyItem with Shop.ItemBought
        {
            string typeOfBoughtItem = this.ShopItems[index].GetType().Name;
            this.ShopItems.RemoveAt(index);
            this.ShopItems.Add(ItemCreate.GetRandomItem(typeOfBoughtItem));
        }

        private void Fill(string type, int count)
        {
            for (int i = 0; i < count; i++)
            {
                bool foundUnique = false;
                while (!foundUnique)
                {
                    var item = ItemCreate.GetRandomItem(type);
                    if (!this.ShopItems.Contains(item))
                    {
                        this.ShopItems.Add(item);
                        foundUnique = true;
                    }
                }
                
            }

        }
        public static void Shuffle<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
