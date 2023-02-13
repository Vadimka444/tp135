namespace ElectronicsStore.Models
{
    public class OrderLine
    {
        public int NumberOrderLine { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int IdProduct { get; set; }
        public Order? Order { get; set; }
        public Product? Product { get; set; }
    }
}
