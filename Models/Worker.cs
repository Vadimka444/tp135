namespace ElectronicsStore.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Post { get; set; }
        public LinkedList<Order> Orders { get; set; } = new();
    }
}
