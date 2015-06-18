
namespace Project.Engine.Items
{
    public abstract class Equipable : Item, Project.Engine.Interfaces.IEquippable
    {
        protected Equipable(long id, string name, int str, int agi, int intel, int hp)
            : base(id, name, str, agi, intel, hp)
        {

        }

        public abstract void Equip(Item item);
    }
}
