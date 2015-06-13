using System;
using System.Collections.Generic;
using GameServer.Interfaces;
using GameServer.Items;

namespace GameServer.GameCharacters
{
    public class Player:Entity,IAtacable
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

        private int _attackBonus=0;
        public int AttackBonus
        {
            get { return _attackBonus; }
            set
            {DataValidator.DataValidator.CheckValidInt(value);
                _attackBonus = value;
            }
        }

        private int _defenceBonus=0;
        public int DefenceBonus
        {
            get { return _defenceBonus; }
            set
            {DataValidator.DataValidator.CheckValidInt(value);
                _defenceBonus = value;
            }
        }
        public Player(string creatureName, int healtPoint, int attackPoint, int defencePoint, int xp, double money)
            : base(creatureName, healtPoint, attackPoint, defencePoint)
        {

            this.Xp = xp;
            this.Money = money;
            
        }

        

        public void Attack(object enemy)
        {
            throw new NotImplementedException();
        }

        public void CalckAttackBonusStats(Weapon weapon)
        {
            this.AttackBonus = weapon.AttackBonus;
        }

        public void CalcDeffenceBonusStats(List<Armor> equipedArmors)
        {
            foreach (var armor in equipedArmors)
            {
                this.DefenceBonus += armor.DefenceBonus;
            }
        }
    }
}
