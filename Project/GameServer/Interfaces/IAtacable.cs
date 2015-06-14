using GameServer.GameCharacters;

namespace GameServer.Interfaces
{
   public interface IAtacable
   {
       void Attack(object enemy);
       void Gethit(Entity character, int atackPower);

   }
}
