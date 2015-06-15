using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GameInterfaces;

namespace GameServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFGameService" in both code and config file together.
    public class WcfGameService : IWcfGameService

    {
       
        public string SayHello()
        {
            return "WCF conection is OK";
        }
    }
}
