using System.Collections.Generic;

namespace Project.Engine.Items
{
    public class Inventory
    {
        private const int MaxInventoryItems = 30;
        private List<Item> inventoryItems = new List<Item>();

        public Inventory()
        {
            
        }

        public void AddItemToInventory(Item item)
        {
            if (this.inventoryItems.Count == MaxInventoryItems)
            {
                // TODO "inventory is full" logic
            }
            else
            {
                this.inventoryItems.Add(item);
            }
        }

        public void RemoveItemFromInventory(Item item)
        {
            this.inventoryItems.Remove(item);
        }
    }
}
