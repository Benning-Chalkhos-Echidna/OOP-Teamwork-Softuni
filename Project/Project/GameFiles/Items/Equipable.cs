
namespace Project.Engine.Items
{
    public abstract class Equipable : Item, Project.Engine.Interfaces.IEquippable
    {
        public override int Price
        {
            get
            {
                return (this.StrModifier + this.AgiModifier + this.IntModifier + this.HPModifier)*40;
            }
        }
        protected Equipable(long id, string subtype, string name, int str, int agi, int intel, int hp)
            : base(id, subtype, name, str, agi, intel, hp)
        {

        }

        public abstract void Equip(Item item);
    }
}
