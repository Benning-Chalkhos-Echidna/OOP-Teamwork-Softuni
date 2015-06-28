using System.Collections.Specialized;
using System.IO;

namespace Project.Engine.Items
{
    public abstract class Item
    {
        private const string ItemsIconsPath = @"..\..\Resources\item_icons\";
        private long id;
        private string name;
        private readonly string subType;

        private int strModifier,
            agiModifier,
            intModifier,
            hpModifier;

        protected Item(long id, string subType, string name, int str, int agi, int intel, int hp)
        {
            this.id = id;
            this.subType = subType;
            this.Name = name;

            this.StrModifier = str;
            this.AgiModifier = agi;
            this.IntModifier = intel;
            this.HPModifier = hp;
        }
        protected Item()
        {

        }

        public abstract int Price { get; }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string ImgPath
        {
            get { return Path.GetFullPath(string.Format("{0}{1}.png", 
                    ItemsIconsPath, this.subType)); }
        }

        public int StrModifier
        {
            get { return this.strModifier; }
            set { this.strModifier = value; }
        }
        public int AgiModifier
        {
            get { return this.agiModifier; }
            set { this.agiModifier = value; }
        }
        public int IntModifier
        {
            get { return this.intModifier; }
            set { this.intModifier = value; }
        }
        public int HPModifier
        {
            get { return this.hpModifier; }
            set { this.hpModifier = value; }
        }
    }
}
