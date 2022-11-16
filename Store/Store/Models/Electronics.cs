namespace Store.Models
{
    public class Electronics
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Class { get; set; }
        public int? Price { get; set; }

        public List<Order> orders { get; set; } = new();
    }
}
