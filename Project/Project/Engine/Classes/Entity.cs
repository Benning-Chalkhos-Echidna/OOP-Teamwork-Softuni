using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine;
namespace Game.CharacterClasses
{
    public enum EntityGender { Male, Female, Unknown }

    public abstract class Entity : IEntity
    {
        protected string _name;
        protected EntityGender _entityGender;
        protected Game.Engine.Player.PlayerClass _entityClass;

        protected int _strength,
            _agility,
            _intellect,
            _health;

        protected int _strengthModifier,
            _agilityModifier,
            _intellectModifier,
            _healthModifier;

        protected int _attack, _defense;

        protected Entity()
        {
            this.Strength = 10;
            this.Agility = 10;
            this.Intellect = 10;
            this.Health = 100;

            this.Name = "";
            this._healthModifier = 50;
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public EntityGender EntityGender
        {
            get { return this._entityGender; }
            set { this._entityGender = value; }
        }
        public int Strength
        {
            get { return this._strength + this._strengthModifier; }
            set { this._strength = value; }
        }
        public int Agility
        {
            get { return this._agility + this._agilityModifier; }
            set { this._agility = value; }
        }
        public int Intellect
        {
            get { return this._intellect + this._intellectModifier; }
            set { this._intellect = value; }
        }
        public int Health
        {
            get { return this._health + this._healthModifier; }
            set { this._health = value; }
        }

        public int Attack
        {
            get { return this._attack + this.Strength + this.Agility; }
            set { this._attack = value; }
        }
        public int Defense
        {
            get { return this._defense + this.Intellect; }
            set { this._defense = value; }
        }
        public Player.PlayerClass EntityClass
        {
            get { return this._entityClass; }
            set { this._entityClass = value; }
        }
        public abstract void Engage(Entity target);
        public abstract void Defend(Entity target);

        public override string ToString()
        {
            return string.Format("{0} - {1} {2}", this.Name, this.EntityGender, this.EntityClass);
        }
    }
}
