using Project.Engine.Exceptions;
using Project.Engine.Interfaces;

namespace Project.Engine.Items
{
    public abstract class Consumable : Item, IConsumable
    {
        private int charges;

        public override int Price
        {
            get
            {
                if (this is HealthPotion)
                {
                    return (this.HPModifier+this.Charges) * 10;
                }
                if (this is StatsPotion)
                {
                    return (this.StrModifier + this.AgiModifier + this.IntModifier
                        + this.HPModifier + this.Charges)*30;
                }
                throw new InvalidItemPriceException(); // message
            }
        }

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
