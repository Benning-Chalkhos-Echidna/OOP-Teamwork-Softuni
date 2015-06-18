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
        public Warrior(EntityGender entityGender, string name, EntityTeam team)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base.Agility += 10;
            base.Strength += 15;
            base.Intellect += 5;
            base.EntityClass = Engine.Player.PlayerClass.Warrior;

            base.Attack = base.Strength;
            base.Defense = base.Strength;

            base.Team = team;
        }
        #region Methods

        #endregion
    }
}
