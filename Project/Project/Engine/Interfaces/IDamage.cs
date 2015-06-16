using System;
namespace Game.CharacterClasses
{
    interface IDamage : IEntity
    {
        void Defend(Entity target);
        void Engage(Entity target);
    }
}
