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
        public Druid(EntityGender entityGender, string name, EntityTeam team)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base.Agility += 6;
            base.Strength += 6;
            base.Intellect += 18;
            base.EntityClass = Engine.Player.PlayerClass.Druid;

            base.Attack = base.Agility;
            base.Defense = base.Strength;

            base.Team = team;
        }
    }
}
