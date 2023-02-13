namespace ElectronicsStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOrder { get; set; }
        public DateTime DateofExecution { get; set; }
        public string Status { get; set; }
        public int ClientId { get; set; }
        public int WorkerNumber { get; set; }
        public Client? Client { get; set; }
        public Worker? Worker { get; set; }
        public LinkedList<Delivery> Delivery { get; set; } = new();
        public LinkedList<OrderLine> OrderLine { get; set; } = new();
    }
}
