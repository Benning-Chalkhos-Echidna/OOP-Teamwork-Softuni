using Project.GameCharacters;

namespace Project.Interfaces
{
   public interface IAtacable
   {
       void Attack(object enemy);
       void Gethit(Entity character, int atackPower);

   }
}
