using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServer.GameEngine.GameCharacters;

namespace GameServer.GameEngine.Interfaces
{
   public interface IAtacable
   {
       void Attack(Enemy enemy);

   }
}
