using Project.Engine.Interfaces;

namespace Project.Engine.Classes
{
    class Paladin : Entity, IEntity, IHeal
    {
        public Paladin(EntityGender entityGender, string name, EntityTeam team)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base.Agility += 12;
            base.Strength += 6;
            base.Intellect += 12;
            base.EntityClass = Engine.Player.PlayerClass.Paladin;

            base.Attack = base.Intellect;
            base.Defense = 5;
            base.EntitySpell = new Spell(SpellType.HealSpell);
            base.EntitySpell.SpellVal = this.Intellect + this.Strength - UI.rnd.Next(1, 6);
            base.EntitySpell.SpellName = "Holy Light";
            base.Team = team;
        }
    }
}
