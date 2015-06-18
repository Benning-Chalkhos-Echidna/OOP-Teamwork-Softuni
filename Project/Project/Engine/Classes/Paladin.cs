using Project.Engine.Interfaces;

namespace Project.Engine.Classes
{
    class Paladin : Entity, IEntity, IHeal
    {
        #region Constructors
        public Paladin()
            : base()
        {

        }
        #endregion
        public Paladin(EntityGender entityGender, string name)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base.Agility += 12;
            base.Strength += 6;
            base.Intellect += 12;

            base.Attack = 25;
            base.Defense = 15;
            base.EntityClass = Engine.Player.PlayerClass.Paladin;
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
