
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
    }
}
