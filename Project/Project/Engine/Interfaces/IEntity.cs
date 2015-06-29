using Project.Engine.Classes;

namespace Project.Engine.Interfaces
{
    public interface IEntity
    {
        int Agility { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        EntityGender EntityGender { get; set; }
        int Health { get; set; }
        int Intellect { get; set; }
        string Name { get; set; }
        int Strength { get; set; }

        bool isAlive { get; set; }
    }
}
