using System.Linq;
using Project.Engine.Interfaces;
using Project.Engine.Items;

namespace Project.Engine.Classes
{
    public enum EntityGender { Male, Female, Unknown }

    public abstract class Entity : IEntity
    {
        protected string _name;
        protected EntityGender _entityGender;
        protected Player.PlayerClass _entityClass;
        protected Inventory inventory;
        protected Equipped equippedItems;

        protected int _strength,
            _agility,
            _intellect,
            _health;

        protected int _strengthModifier,
            _agilityModifier,
            _intellectModifier,
            _healthModifier;

        protected int _attack, _defense;

        protected Entity()
        {
            this.Strength = 10;
            this.Agility = 10;
            this.Intellect = 10;
            this.Health = 100;

            this.Name = "";
            this._healthModifier = 50;
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public EntityGender EntityGender
        {
            get { return this._entityGender; }
            set { this._entityGender = value; }
        }
        public int Strength
        {
            get { return this._strength + this._strengthModifier; }
            set { this._strength = value; }
        }
        public int Agility
        {
            get { return this._agility + this._agilityModifier; }
            set { this._agility = value; }
        }
        public int Intellect
        {
            get { return this._intellect + this._intellectModifier; }
            set { this._intellect = value; }
        }
        public int Health
        {
            get { return this._health + this._healthModifier; }
            set { this._health = value; }
        }

        public int Attack
        {
            get { return this._attack + this.Strength + this.Agility; }
            set { this._attack = value; }
        }
        public int Defense
        {
            get { return this._defense + this.Intellect; }
            set { this._defense = value; }
        }
        public Player.PlayerClass EntityClass
        {
            get { return this._entityClass; }
            set { this._entityClass = value; }
        }
        public abstract void Engage(Entity target);
        public abstract void Defend(Entity target);

        public void AddItemToInventory(Item item)
        {
            if (this.inventory.InventoryItemsCount == 30)
            {
                // TODO "inventory is full" logic
            }
            else
            {
                this.inventory.InventoryItems.Add(item);
            }
        }

        public void EquipItem(Item item)
        {
            if (item is IEquippable)
            {
                Item oldItem;
                if (item is Weapon)
                {
                    oldItem = this.equippedItems.Weapon;
                    this.equippedItems.Weapon = item as Weapon;
                    this.inventory.InventoryItems.Remove(item);
                    this.inventory.InventoryItems.Add(oldItem);
                }
                else if (item is HeadGear)
                {
                    oldItem = this.equippedItems.HeadGear;
                    this.equippedItems.HeadGear = item as HeadGear;
                    this.inventory.InventoryItems.Remove(item);
                    this.inventory.InventoryItems.Add(oldItem);
                }
                else if (item is ChestGear)
                {
                    oldItem = this.equippedItems.ChestGear;
                    this.equippedItems.ChestGear = item as ChestGear;
                    this.inventory.InventoryItems.Remove(item);
                    this.inventory.InventoryItems.Add(oldItem);
                }
                else if (item is HandsGear)
                {
                    oldItem = this.equippedItems.HandsGear;
                    this.equippedItems.HandsGear = item as HandsGear;
                    this.inventory.InventoryItems.Remove(item);
                    this.inventory.InventoryItems.Add(oldItem);
                }
                else if (item is LegsGear)
                {
                    oldItem = this.equippedItems.LegsGear;
                    this.equippedItems.LegsGear = item as LegsGear;
                    this.inventory.InventoryItems.Remove(item);
                    this.inventory.InventoryItems.Add(oldItem);
                }

                AddModifiersFromEquippedItems();
            }
            else if (item is IConsumable)
            {
                if (item is HealthPotion)
                {
                    this._healthModifier += (item as HealthPotion).HPModifier;
                    (item as HealthPotion).Charges--;
                }
                else if (item is StatsPotion)
                {
                    this._intellectModifier += (item as StatsPotion).HPModifier;
                    this._agilityModifier += (item as StatsPotion).HPModifier;
                    this._strengthModifier += (item as StatsPotion).HPModifier;
                    (item as StatsPotion).Charges--;
                }
            }
            else
            {
                //todo "This item cannot be equipped" logic
            }
        }

        public void RemoveItemFromInventory(Item item)
        {
            this.inventory.InventoryItems.Remove(item);
        }

        public void AddModifiersFromEquippedItems()
        {
            this.equippedItems.CalculateEquippedItemsModifiers();
            this._strengthModifier = this.equippedItems.EquippedItemsStrModifier;
            this._agilityModifier = this.equippedItems.EquippedItemsAgiModifier;
            this._intellectModifier = this.equippedItems.EquippedItemsIntModifier;
            this._healthModifier = this.equippedItems.EquippedItemsHPModifier;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} {2}", this.Name, this.EntityGender, this.EntityClass);
        }
    }
}
