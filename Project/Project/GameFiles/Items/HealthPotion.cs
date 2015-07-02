
namespace Project.Engine.Items
{
    public class HealthPotion : Consumable
    {
        public HealthPotion
            (long id, string subtype, string name, int str, int agi, int intel, int hp, int charges)
            : base(id, subtype, name, str, agi, intel, hp, charges)
        {
            
        }

        public override void Consume(Item item)
        {
            throw new System.NotImplementedException();
        }
    }
}
