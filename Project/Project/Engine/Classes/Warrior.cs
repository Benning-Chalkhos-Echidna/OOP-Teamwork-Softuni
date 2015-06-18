using Project.Engine.Interfaces;

namespace Project.Engine.Classes
{
    public class Warrior : Entity, IEntity, IDamage
    {
        #region Constructors
        public Warrior()
            : base()
        {

        }
        #endregion
        public Warrior(EntityGender entityGender, string name)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base.Agility += 10;
            base.Strength += 15;
            base.Intellect += 5;

            base.Attack = 35;
            base.Defense = 5;
            base.EntityClass = Engine.Player.PlayerClass.Warrior;
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
