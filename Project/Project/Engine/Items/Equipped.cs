
using Project.Engine.Classes;

namespace Project.Engine.Items
{
    public class Equipped
    {
        //todo

        private Weapon weapon;
        private HeadGear headgear;
        private ChestGear chestGear;
        private HandsGear handsGear;
        private LegsGear legsGear;

        //private int equippedItemsStrModifier;
        //private int equippedItemsAgiModifier;
        //private int equippedItemsIntModifier;
        //private int equippedItemsHPModifier;

        public Weapon Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        public HeadGear HeadGear
        {
            get { return this.headgear; }
            set { this.headgear = value; }
        }

        public ChestGear ChestGear
        {
            get { return this.chestGear; }
            set { this.chestGear = value; }
        }

        public HandsGear HandsGear
        {
            get { return this.handsGear; }
            set { this.handsGear = value; }
        }

        public LegsGear LegsGear
        {
            get { return this.legsGear; }
            set { this.legsGear = value; }
        }

        public int EquippedItemsStrModifier { get; set; }
        public int EquippedItemsAgiModifier { get; set; }
        public int EquippedItemsIntModifier { get; set; }
        public int EquippedItemsHPModifier { get; set; }

        public void CalculateEquippedItemsModifiers()
        {
            this.EquippedItemsStrModifier = 
                this.Weapon.StrModifier + this.HeadGear.StrModifier + this.ChestGear.StrModifier +
                this.HandsGear.StrModifier + this.LegsGear.StrModifier;
            this.EquippedItemsAgiModifier =
                this.Weapon.AgiModifier + this.HeadGear.AgiModifier + this.ChestGear.AgiModifier +
                this.HandsGear.AgiModifier + this.LegsGear.AgiModifier;
            this.EquippedItemsIntModifier =
                this.Weapon.IntModifier + this.HeadGear.IntModifier + this.ChestGear.IntModifier +
                this.HandsGear.IntModifier + this.LegsGear.IntModifier;
            this.EquippedItemsHPModifier =
                this.Weapon.HPModifier + this.HeadGear.HPModifier + this.ChestGear.HPModifier +
                this.HandsGear.HPModifier + this.LegsGear.HPModifier;
        }
    }
}
