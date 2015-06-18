using Project.Engine.Classes;

namespace Project.Engine.Interfaces
{
    interface IEntity
    {
        int Agility { get; set; }
        int Attack { get; set; }
        void Defend(Entity target);

        int Defense { get; set; }
        void Engage(Entity target);

        EntityGender EntityGender { get; set; }
        int Health { get; set; }
        int Intellect { get; set; }
        string Name { get; set; }
        int Strength { get; set; }
    }
}
