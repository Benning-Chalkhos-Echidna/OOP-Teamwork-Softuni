using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using GameServer.Server;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(GameService)))
            {
                host.Open();
                Console.WriteLine( @"Game server running");
                Console.ReadLine();
            }
        }
    }
}
