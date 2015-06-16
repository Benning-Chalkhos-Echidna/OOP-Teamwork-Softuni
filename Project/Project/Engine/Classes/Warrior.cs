using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CharacterClasses
{
    public class Warrior : Entity, IEntity, IDamage
    {
        #region Constructors
        public Warrior()
            : base()
        {

        }
        #endregion
        public Warrior(EntityGender entityGender, string name)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base._agilityModifier = 10;
            base._strengthModifier = 15;
            base._intellectModifier = 5;

            base._attack = 35;
            base._defense = 5;
            base.EntityClass = Engine.Player.PlayerClass.Warrior;
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
