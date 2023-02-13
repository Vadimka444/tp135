namespace ElectronicsStore.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public LinkedList<Order> Order { get; set; } = new();
    }
}
