using Project.Engine.Interfaces;

namespace Project.Engine.Classes
{
    public class Mage : Entity, IEntity, IDamage
    {
        #region Constructors
        public Mage()
            : base()
        {

        }
        #endregion
        public Mage(EntityGender entityGender, string name)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base.Agility += 5;
            base.Strength += 5;
            base.Intellect += 20;

            base.Attack = 20;
            base.Defense = 10;
            base.EntityClass = Engine.Player.PlayerClass.Mage;
        }
        #region Methods
        public override void Engage(Entity target)
        {
            target.Health -= this.Attack;
        }
        public override void Defend(Entity target)
        {
            this.Health -= (target.Attack - this.Defense);
        }
        #endregion
    }
}
