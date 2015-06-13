
namespace IWcfServiceble.GameCharacters
{
    public abstract class Entity
    {
        private string _creatureName;
        public string CreatureName
        {
            get { return _creatureName; }
            set
            {
                DataValidator.DataValidator.CheckString(value);
                _creatureName = value;
            }
        }
        private int _healtPoint;
        public int HealtPoint 
        {
            get { return _healtPoint; }
            set
            {
                DataValidator.DataValidator.CheckValidInt(value);
                _healtPoint = value;
            }
        }

        private int _defencePoints;
        public int DefencePoints
        {
            get { return _defencePoints; }
            set
            {
                DataValidator.DataValidator.CheckValidInt(value);
                _defencePoints = value;
            }
        }
        
        private int _attackPoints;
        public int AttackPoints
        {
            get { return _attackPoints; }
            set
            {
                DataValidator.DataValidator.CheckValidInt(value);
                _attackPoints = value;
            }
        }

        protected Entity(string creatureName,int healtPoint, int attackPoint,int defencePoint)
        {
            this.CreatureName = creatureName;
            this.HealtPoint = healtPoint;
            this.AttackPoints = attackPoint;
            this.DefencePoints = defencePoint;
        }
    }
}
