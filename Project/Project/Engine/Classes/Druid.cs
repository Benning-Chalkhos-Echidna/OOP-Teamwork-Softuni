﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CharacterClasses
{
    public class Druid : Entity, IEntity, IHeal
    {
        #region Constructors
        public Druid()
            : base()
        {

        }
        #endregion
        public Druid(EntityGender entityGender, string name)
        {
            base.EntityGender = entityGender;
            base.Name = name;

            base._agilityModifier = 12;
            base._strengthModifier = 6;
            base._intellectModifier = 12;

            base._attack = 25;
            base._defense = 15;
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