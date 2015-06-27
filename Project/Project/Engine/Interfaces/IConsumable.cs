namespace Project.Engine.Items
{
    interface IConsumable
    {
        int Charges { get; set; }

        void Consume(Item item);
    }
}
