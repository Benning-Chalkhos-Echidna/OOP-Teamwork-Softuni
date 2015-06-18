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
        public Mage(EntityGender entityGender, string name, EntityTeam team)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base.Agility += 5;
            base.Strength += 5;
            base.Intellect += 20;
            base.EntityClass = Engine.Player.PlayerClass.Mage;

            base.Attack = base.Intellect;
            base.Defense = base.Strength;

            base.Team = team;
        }
        #region Methods

        #endregion
    }
}
