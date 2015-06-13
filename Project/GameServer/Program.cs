using System;
using System.ServiceModel;
using GameInterfaces;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(WcfGameService)))
            {
                host.Open();
                Console.WriteLine(@"Game server running");
                Console.ReadLine();
            }
        }
    }
}
