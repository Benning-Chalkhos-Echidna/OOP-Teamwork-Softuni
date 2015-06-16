using System;
namespace Game.CharacterClasses
{
    interface IHeal : IEntity
    {
        void Defend(Entity target);
        void Engage(Entity target);
    }
}
