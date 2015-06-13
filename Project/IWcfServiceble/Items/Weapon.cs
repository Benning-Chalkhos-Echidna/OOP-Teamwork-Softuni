namespace IWcfServiceble.Items
{
   public class Weapon:CharacterItem
   {
       private int _attackBonus;

       public int AttackBonus
       {
           get { return _attackBonus; }
           set
           {DataValidator.DataValidator.CheckValidInt(value);
               _attackBonus = value;
           }
       }
       public Weapon(int price, int dropShance, int attackBonus)
           : base(price, dropShance)
       {
           this.AttackBonus = attackBonus;
       }

       
   }
}
