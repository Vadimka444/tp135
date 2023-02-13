namespace ElectronicsStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UnitOfMeasurement { get; set; }
        public int Price { get; set; }
        public LinkedList<OrderLine> OrderLine { get; set; } = new();
        public LinkedList<Batch> Batch { get; set; } = new();
    }
}
