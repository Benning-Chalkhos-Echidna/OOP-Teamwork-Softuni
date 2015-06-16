using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine
{
    public class Engine
    {
        public Engine()
        {
            this.Start();
        }
        private void Start()
        {
            UI.PrintLoginScreen();
            UI.PrintMainMenu();
            //Take and Process Input
            //Iterate the time
            //Collision checks
            //KeyListeners
        }
    }
}
