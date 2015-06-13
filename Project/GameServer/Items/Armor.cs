namespace GameServer.Items
{
    public enum TypeArmor { Head, Leg, Glove, Boots, Pants }
    public class Armor:CharacterItem
    {
        public TypeArmor TypeArmor { get; set; }

        private int _defenceBonus;
        public int DefenceBonus
        {
            get { return _defenceBonus; }
            set
            {DataValidator.DataValidator.CheckValidInt(value);
                _defenceBonus = value;
            }
        }
        public Armor(int price, int dropShance, int defenceBonus,TypeArmor typeArmor)
            : base(price, dropShance)
        {
            this.DefenceBonus = defenceBonus;
            this.TypeArmor = typeArmor;
        }
    }
}
