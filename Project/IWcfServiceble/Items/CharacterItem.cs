namespace IWcfServiceble.Items
{
   public abstract class CharacterItem
    {
        private int _price;
        public int Price
        {
            get { return _price; }
            set
            {DataValidator.DataValidator.CheckValidInt(value);
                _price = value;
            }
        }

        private int _dropShance;
        public int DropShance
        {
            get { return _dropShance; }
            set
            {DataValidator.DataValidator.CheckValidInt(value);
                _dropShance = value;
            }
        }

       protected CharacterItem(int price,int dropShance)
       {
           this.Price = price;
           this.DropShance = dropShance;
       }
    }
}
