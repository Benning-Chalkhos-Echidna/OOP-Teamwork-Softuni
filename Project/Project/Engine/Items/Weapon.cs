
using Project.Engine.Interfaces;

namespace Project.Engine.Items
{
    public class Weapon : Equipable
    {
        public Weapon(long id, string subtype, string name, int str, int agi, int intel, int hp)
            : base(id, subtype, name, str, agi, intel, hp)
        {

        }

        public override void Equip(Item item)
        {
            throw new System.NotImplementedException();
        }
    }
}
