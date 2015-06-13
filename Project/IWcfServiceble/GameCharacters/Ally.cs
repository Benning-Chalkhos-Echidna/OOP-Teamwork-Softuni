using System;
using IWcfServiceble.Interfaces;

namespace IWcfServiceble.GameCharacters
{
    public class Ally:Entity,IAtacable
    {
        private int _helpPotencial;
        public int HelpPotencial
        {
            get { return _helpPotencial; }
            set
            {DataValidator.DataValidator.CheckValidInt(value);
                _helpPotencial = value;
            }
        }
        public Ally(string creatureName, int healtPoint, int attackPoint, int defencePoint,int helpPotencial) : base(creatureName, healtPoint, attackPoint, defencePoint)
        {
            this.HelpPotencial = helpPotencial;
        }

    
        public void Attack(object enemy)
        {
            throw new NotImplementedException();
        }
    }
}
