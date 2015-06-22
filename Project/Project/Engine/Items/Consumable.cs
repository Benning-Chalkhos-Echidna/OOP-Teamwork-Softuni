namespace Project.Engine.Items
{
    public abstract class Consumable : Item, IConsumable
    {
        private int charges;

        protected Consumable(long id, string subtype, string name, int str, int agi, int intel, int hp, int charges)
            : base(id, subtype, name, str, agi, intel, hp)
        {
            this.Charges = charges;
        }

        public int Charges
        {
            get { return this.charges; }
            set { this.charges = value; }
        }

        public abstract void Consume(Item item);
    }
}
