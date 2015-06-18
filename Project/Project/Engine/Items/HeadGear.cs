using Project.Engine.Interfaces;

namespace Project.Engine.Items
{
    public class HeadGear : Equipable
    {
        public HeadGear(long id, string name, int str, int agi, int intel, int hp)
            : base(id, name, str, agi, intel, hp)
        {

        }

        public override void Equip(Item item)
        {
            throw new System.NotImplementedException();
        }
    }
}
