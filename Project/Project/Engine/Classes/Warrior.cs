using Project.Engine.Interfaces;

namespace Project.Engine.Classes
{
    public class Warrior : Entity, IEntity, IDamage
    {
        public Warrior(EntityGender entityGender, string name, EntityTeam team)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base.Agility += 10;
            base.Strength += 15;
            base.Intellect += 5;
            base.EntityClass = Engine.Player.PlayerClass.Warrior;

            base.Attack = base.Strength;
            base.Defense = 5;
            base.EntitySpell = new Spell(SpellType.DamageSpell);
            base.EntitySpell.SpellVal = (this.Strength * 2) - UI.rnd.Next(1, 6);
            base.EntitySpell.SpellName = "Powerful Shout";
            base.Team = team;
        }
    }
}
