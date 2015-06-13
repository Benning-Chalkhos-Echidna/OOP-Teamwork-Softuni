using System;
using GameServer.Interfaces;

namespace GameServer.GameCharacters
{
    public class Enemy:Entity,IAtacable
    {
        private int _xpReward;

       

        public int XpReward
        {
            get { return _xpReward; }
            set
            {DataValidator.DataValidator.CheckValidInt(value);
                _xpReward = value;
            }
        }

        private double _moneyDrop;
        public double MoneyDrop
        {
            get { return _moneyDrop; }
            set
            {
                DataValidator.DataValidator.CheckValidInt(Convert.ToInt32(value));
                _moneyDrop = value;
            }
        }

        private int _dificulty;
        public int Dificulty
        {
            get { return _dificulty; }
            set
            {DataValidator.DataValidator.CheckValidInt(value);
                _dificulty = value;
            }
        }
        public Enemy(string creatureName, int healtPoint, int attackPoint, int defencePoint, int xpReward, double moneyDrop,int dificulty)
            : base(creatureName, healtPoint, attackPoint, defencePoint)
        {
            this.XpReward = xpReward;
            this.MoneyDrop = moneyDrop;
            this.Dificulty = dificulty;
        }

        public void Attack(object enemy)
        {
            throw new NotImplementedException();
        }
    }
}
