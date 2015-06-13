using System.Runtime.Serialization;
using GameServer.GameCharacters;

namespace GameServer.BattleCalculator
{
    [DataContract]
    public class BattleCalculator
    {
        [DataMember]
        public Player PlayerReal { get; set; }

        [DataMember]
        public Ally Ally { get; set; }

        [DataMember]
        public Enemy Enemy { get; set; }

    }
}
