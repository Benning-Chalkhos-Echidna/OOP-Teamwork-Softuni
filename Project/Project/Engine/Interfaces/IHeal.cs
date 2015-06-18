using Project.Engine.Classes;

namespace Project.Engine.Interfaces
{
    interface IHeal : IEntity
    {
        void Defend(Entity target);
        void Engage(Entity target);
    }
}
