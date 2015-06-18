using Project.Engine.Interfaces;

namespace Project.Engine.Classes
{
    public class Druid : Entity, IEntity, IHeal
    {
        #region Constructors
        public Druid()
            : base()
        {

        }
        #endregion
        public Druid(EntityGender entityGender, string name)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base.Agility += 6;
            base.Strength += 6;
            base.Intellect += 18;

            base.Attack = 25;
            base.Defense = 15;
            base.EntityClass = Engine.Player.PlayerClass.Druid;
        }
        #region Methods
        public override void Engage(Entity target)
        {
            target.Health += this.Attack;
        }
        public override void Defend(Entity target)
        {
            this.Health -= (target.Attack - this.Defense);
        }
        #endregion
    }
}
