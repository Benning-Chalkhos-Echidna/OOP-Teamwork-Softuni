using Project.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
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
