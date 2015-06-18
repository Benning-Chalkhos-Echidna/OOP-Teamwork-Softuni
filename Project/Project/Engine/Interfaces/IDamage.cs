using Project.Engine.Classes;

namespace Project.Engine.Interfaces
{
    interface IDamage : IEntity
    {
        void Defend(Entity target);
        void Engage(Entity target);
    }
}
