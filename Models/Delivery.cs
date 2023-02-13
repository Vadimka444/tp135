namespace ElectronicsStore.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public int OrderId { get; set; }
        public string Status { get; set; }
        public Order? Order { get; set; }
    }
}
