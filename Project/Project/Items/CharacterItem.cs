namespace Project.Items
{
   public abstract class CharacterItem
   {
       private string _itemName;
       public string ItemName
       {
           get { return _itemName; }
           set
           {DataValidator.DataValidator.CheckString(value);
               _itemName = value;
           }
       }
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

       protected CharacterItem(int price,int dropShance,string itemName)
       {
           this.Price = price;
           this.DropShance = dropShance;
           this.ItemName = itemName;
       }
    }
}
