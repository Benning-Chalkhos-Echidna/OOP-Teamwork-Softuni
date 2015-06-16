using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CharacterClasses
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

            base._agilityModifier = 12;
            base._strengthModifier = 6;
            base._intellectModifier = 12;

            base._attack = 25;
            base._defense = 15;
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
