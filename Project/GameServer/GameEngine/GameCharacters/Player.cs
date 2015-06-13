using System;
using System.Collections.Generic;
using GameServer.GameEngine.Interfaces;
using GameServer.GameEngine.Items;

namespace GameServer.GameEngine.GameCharacters
{
    class Player:Entity,IAtacable
    {
        
        private int _xp;
        public int Xp
        {
            get { return _xp; }
            set { _xp = value; }
        }

        private double _money;
        public double Money
        {
            get { return _money; }
            set
            {DataValidator.DataValidator.CheckValidInt(Convert.ToInt32(value));//!!!!
                _money = value;
            }
        }

        public Dictionary<string, int> CharacterInventuryBonus { get; set; }

        public Player(string creatureName, int healtPoint, int attackPoint, int defencePoint, int xp, double money)
            : base(creatureName, healtPoint, attackPoint, defencePoint)
        {
            this.Xp = xp;
            this.Money = money;
            this.CharacterInventuryBonus=new Dictionary<string, int>();
        }

        

        public void Attack(object enemy)
        {
            throw new NotImplementedException();
        }
    }
}
