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
        public Paladin(EntityGender entityGender, string name, EntityTeam team)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base.Agility += 12;
            base.Strength += 6;
            base.Intellect += 12;
            base.EntityClass = Engine.Player.PlayerClass.Paladin;

            base.Attack = base.Intellect;
            base.Defense = base.Strength;

            base.Team = team;
        }
        #region Methods

        #endregion
    }
}
