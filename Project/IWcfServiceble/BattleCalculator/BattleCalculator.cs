using System.Media;
using System.Runtime.Serialization;
using IWcfServiceble.GameCharacters;

namespace IWcfServiceble.BattleCalculator
{
    [DataContract]
    public class BattleCalculator
    {
        [DataMember]
        public Player Player1 { get; set; }

        [DataMember]
        public Ally Ally { get; set; }

        [DataMember]
        public Enemy Enemy { get; set; }

    }
}
