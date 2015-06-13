
using GameServer.DataValidator;

namespace Project.Entities.GameCharacters
{
    public abstract class Entity
    {
        private string _creatureName;
        public string CreatureName
        {
            get { return _creatureName; }
            set
            {DataValidator.CheckString(value);
                _creatureName = value;
            }
        }
        private int _healtPoint;
        public int HealtPoint 
        {
            get { return _healtPoint; }
            set
            {
                DataValidator.CheckValidInt(value);
                _healtPoint = value;
            }
        }

        private int _defencePoints;
        public int DefencePoints
        {
            get { return _defencePoints; }
            set
            {
                DataValidator.CheckValidInt(value);
                _defencePoints = value;
            }
        }
        
        private int _attackPoints;
        public int AttackPoints
        {
            get { return _attackPoints; }
            set
            {DataValidator.CheckValidInt(value);
                _attackPoints = value;
            }
        }

        public Entity(string creatureName,int healtPoint, int attackPoint,int defencePoint)
        {
            this.CreatureName = creatureName;
            this.HealtPoint = healtPoint;
            this.AttackPoints = attackPoint;
            this.DefencePoints = defencePoint;
        }
    }
}
