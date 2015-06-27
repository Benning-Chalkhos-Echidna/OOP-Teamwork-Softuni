using Project.Engine.Interfaces;
using Project.Engine.Items;
using System.ComponentModel;

namespace Project.Engine.Classes
{
    public enum EntityGender { Male, Female, Unknown }
    public enum EntityTeam { Ally, Enemy, Player }

    public abstract class Entity : IEntity, INotifyPropertyChanged
    {
        protected int gold;
        protected string _name;
        protected EntityGender _entityGender;
        protected Player.PlayerClass _entityClass;
        protected Inventory inventory;
        protected Equipped equippedItems;

        protected int _strength,
            _agility,
            _intellect,
            _health;

        protected int _attack, _defense;

        protected Entity()
        {
            this.Gold = 1000;
            this.Strength = 10;
            this.Agility = 10;
            this.Intellect = 10;
            this.Health = 100;
            this.Name = "";
            this.isAlive = true;
            this.inventory = new Inventory();
            this.equippedItems = new Equipped();
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public int Gold
        {
            get { return this.gold; }
            set
            {
                this.gold = value;
                OnPropertyChanged("Gold");
            }
        }
        public EntityGender EntityGender
        {
            get { return this._entityGender; }
            set { this._entityGender = value; }
        }
        public int Strength
        {
            get { return this._strength; }
            set
            {
                this._strength = value;
                OnPropertyChanged("Strength");
            }
        }
        public int Agility
        {
            get { return this._agility; }
            set
            {
                this._agility = value;
                OnPropertyChanged("Agility");
            }
        }
        public bool isAlive { get; set; }
        public int Intellect
        {
            get { return this._intellect; }
            set
            {
                this._intellect = value;
                OnPropertyChanged("Intellect");
            }
        }
        public int Health
        {
            get { return this._health; }
            set
            {
                this._health = value;
                OnPropertyChanged("Health");
            }
        }

        public Player.PlayerClass EntityClass
        {
            get { return this._entityClass; }
            set { this._entityClass = value; }
        }

        public void AddItemToInventory(Item item)
        {
            if (this.inventory.InventoryItemsCount == 10)
            {
                // TODO "inventory is full" logic
            }
            else
            {
                this.inventory.InventoryItems.Add(item);
            }
        }
        public EntityTeam Team { get; set; }

        public void BuyItem(Item item) // or by shop index
        {
            if (this.inventory.InventoryItemsCount == 10)
            {
                // inventory is full - cannot buy
            }
            else if (item.Price > this.Gold)
            {
                // not enough money - cannot buy
            }
            else
            {
                this.inventory.InventoryItems.Add(item);
                this.Gold -= item.Price;
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
                    if (oldItem != null)
                    {
                        this.inventory.InventoryItems.Add(oldItem);
                    }                   
                }
                else if (item is HeadGear)
                {
                    oldItem = this.equippedItems.HeadGear;
                    this.equippedItems.HeadGear = item as HeadGear;
                    this.inventory.InventoryItems.Remove(item);
                    if (oldItem != null)
                    {
                        this.inventory.InventoryItems.Add(oldItem);
                    }
                }
                else if (item is ChestGear)
                {
                    oldItem = this.equippedItems.ChestGear;
                    this.equippedItems.ChestGear = item as ChestGear;
                    this.inventory.InventoryItems.Remove(item);
                    if (oldItem != null)
                    {
                        this.inventory.InventoryItems.Add(oldItem);
                    }
                }
                else if (item is HandsGear)
                {
                    oldItem = this.equippedItems.HandsGear;
                    this.equippedItems.HandsGear = item as HandsGear;
                    this.inventory.InventoryItems.Remove(item);
                    if (oldItem != null)
                    {
                        this.inventory.InventoryItems.Add(oldItem);
                    }
                }
                else if (item is LegsGear)
                {
                    oldItem = this.equippedItems.LegsGear;
                    this.equippedItems.LegsGear = item as LegsGear;
                    this.inventory.InventoryItems.Remove(item);
                    if (oldItem != null)
                    {
                        this.inventory.InventoryItems.Add(oldItem);
                    }
                }

                AddModifiersFromEquippedItems();
            }
            else if (item is IConsumable)   // maybe this should not be here
            {
                if (item is HealthPotion)
                {
                    this.Health += (item as HealthPotion).HPModifier;
                    (item as HealthPotion).Charges--;
                }
                else if (item is StatsPotion)
                {
                    this.Intellect += (item as StatsPotion).IntModifier;
                    this.Agility += (item as StatsPotion).AgiModifier;
                    this.Strength += (item as StatsPotion).StrModifier;
                    (item as StatsPotion).Charges--;
                }
            }
            else
            {
                //todo "This item cannot be equipped" logic
            }
        }

        public void RemoveItemFromInventory(int index)
        {
            this.inventory.InventoryItems.RemoveAt(index);
        }

        public void AddModifiersFromEquippedItems()
        {
            this.equippedItems.CalculateEquippedItemsModifiers();
            this.Strength = this.equippedItems.EquippedItemsStrModifier;
            this.Agility = this.equippedItems.EquippedItemsAgiModifier;
            this.Intellect = this.equippedItems.EquippedItemsIntModifier;
            this.Health = this.equippedItems.EquippedItemsHPModifier;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} {2}", this.Name, this.EntityGender, this.EntityClass);
        }


        public int Attack
        {
            get
            {
                return this._attack;
            }
            set
            {
                this._attack = value;
                OnPropertyChanged("Attack");
            }
        }


        public int Defense
        {
            get
            {
                return this._defense;
            }
            set
            {
                this._defense = value;
                OnPropertyChanged("Health");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {

                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
