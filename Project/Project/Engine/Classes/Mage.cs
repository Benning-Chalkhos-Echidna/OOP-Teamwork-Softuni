using Project.Engine.Interfaces;

namespace Project.Engine.Classes
{
    public class Mage : Entity, IEntity, IDamage
    {

        public Mage(EntityGender entityGender, string name, EntityTeam team)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base.Agility += 5;
            base.Strength += 5;
            base.Intellect += 20;
            base.EntityClass = Engine.Player.PlayerClass.Mage;

            base.Attack = base.Intellect;
            base.Defense = 5;
            base.EntitySpell = new Spell(SpellType.DamageSpell);
            base.EntitySpell.SpellVal = (this.Intellect * 2) - UI.rnd.Next(1, 6);
            base.Team = team;
        }
    }
}
