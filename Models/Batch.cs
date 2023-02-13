namespace ElectronicsStore.Models
{
    public class Batch
    {
        public int Number { get; set; }
        public int NumberSupplier { get; set; }
        public int IdProduct { get; set; }
        public int QuantityOfGoods { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public Product? Product { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
