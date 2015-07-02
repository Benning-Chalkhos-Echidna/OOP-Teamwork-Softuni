

namespace Project.Engine.Items
{
    public struct Equipped
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
                (this.Weapon == null ? 0 : this.Weapon.StrModifier) + 
                (this.HeadGear == null ? 0 : this.HeadGear.StrModifier) + 
                (this.ChestGear == null ? 0 : this.ChestGear.StrModifier) +
                (this.HandsGear == null ? 0 : this.HandsGear.StrModifier) + 
                (this.LegsGear == null ? 0 : this.LegsGear.StrModifier);
            this.EquippedItemsAgiModifier =
                (this.Weapon == null ? 0 : this.Weapon.AgiModifier) +
                (this.HeadGear == null ? 0 : this.HeadGear.AgiModifier) +
                (this.ChestGear == null ? 0 : this.ChestGear.AgiModifier) +
                (this.HandsGear == null ? 0 : this.HandsGear.AgiModifier) +
                (this.LegsGear == null ? 0 : this.LegsGear.AgiModifier);
            this.EquippedItemsIntModifier =
                (this.Weapon == null ? 0 : this.Weapon.IntModifier) +
                (this.HeadGear == null ? 0 : this.HeadGear.IntModifier) +
                (this.ChestGear == null ? 0 : this.ChestGear.IntModifier) +
                (this.HandsGear == null ? 0 : this.HandsGear.IntModifier) +
                (this.LegsGear == null ? 0 : this.LegsGear.IntModifier);
            this.EquippedItemsHPModifier =
                (this.Weapon == null ? 0 : this.Weapon.HPModifier) +
                (this.HeadGear == null ? 0 : this.HeadGear.HPModifier) +
                (this.ChestGear == null ? 0 : this.ChestGear.HPModifier) +
                (this.HandsGear == null ? 0 : this.HandsGear.HPModifier) +
                (this.LegsGear == null ? 0 : this.LegsGear.HPModifier);
        }
    }
}
