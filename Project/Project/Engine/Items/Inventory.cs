using System.Collections.Generic;

namespace Project.Engine.Items
{
    public class Inventory
    {
        private List<Item> inventoryItems = new List<Item>();
        private Equipped equippedItems;

        public int InventoryItemsCount
        {
            get { return this.inventoryItems.Count; }
        }

        public List<Item> InventoryItems
        {
            get { return this.inventoryItems; }
        } 

        public Inventory()
        {
            
        }
    }
}
