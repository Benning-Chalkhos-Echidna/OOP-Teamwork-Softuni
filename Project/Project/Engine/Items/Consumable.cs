namespace Project.Engine.Items
{
    public abstract class Consumable : Item
    {
        private int charges;
        protected Consumable(long id, string name, int str, int agi, int intel, int hp, int charges)
            : base(id, name, str, agi, intel, hp)
        {
            this.Charges = charges;
        }
        protected Consumable()
        {

        }
        public int Charges
        {
            get { return this.charges; }
            set { this.charges = value; }
        }

        public virtual void Consume()
        {
            this.charges--;
        }
    }
}
