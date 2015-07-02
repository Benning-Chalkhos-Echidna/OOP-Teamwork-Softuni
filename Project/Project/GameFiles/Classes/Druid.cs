using Project.Engine.Interfaces;

namespace Project.Engine.Classes
{
    public class Druid : Entity, IEntity, IHeal
    {
        public Druid(EntityGender entityGender, string name, EntityTeam team)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base.Agility += 6;
            base.Strength += 6;
            base.Intellect += 18;
            base.EntityClass = Engine.Player.PlayerClass.Druid;

            base.Attack = base.Agility;
            base.Defense = 5;
            base.EntitySpell = new Spell(SpellType.HealSpell);
            base.EntitySpell.SpellVal = this.Agility + this.Strength - UI.rnd.Next(1, 6);
            base.EntitySpell.SpellName = "Nature's Restoration";
            base.EntitySpell.SpellCost = 50;
            base.Team = team;
        }
    }
}
