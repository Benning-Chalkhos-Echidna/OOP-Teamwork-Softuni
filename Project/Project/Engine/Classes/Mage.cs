using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CharacterClasses
{
    public class Mage : Entity, IEntity, IDamage
    {
        #region Constructors
        public Mage()
            : base()
        {

        }
        #endregion
        public Mage(EntityGender entityGender, string name)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base._agilityModifier = 5;
            base._strengthModifier = 5;
            base._intellectModifier = 20;

            base._attack = 20;
            base._defense = 10;
            base.EntityClass = Engine.Player.PlayerClass.Mage;
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
