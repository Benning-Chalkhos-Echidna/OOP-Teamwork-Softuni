using System;

namespace Project.Engine.Items
{
    public class HandsGear : Equipable
    {
        public HandsGear(long id, string subtype, string name, int str, int agi, int intel, int hp)
            : base(id, subtype, name, str, agi, intel, hp)
        {

        }

        public override void Equip(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
