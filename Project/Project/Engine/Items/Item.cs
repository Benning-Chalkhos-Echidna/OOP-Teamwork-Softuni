namespace Project.Engine.Items
{
    public abstract class Item
    {
        private long id;
        private string name;

        private int strModifier,
            agiModifier,
            intModifier,
            hpModifier;

        protected Item(long id, string name, int str, int agi, int intel, int hp)
        {
            this.id = id;
            this.name = name;

            this.StrModifier = str;
            this.AgiModifier = agi;
            this.IntModifier = intel;
            this.HPModifier = hp;
        }
        protected Item()
        {

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
