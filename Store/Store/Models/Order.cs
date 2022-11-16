namespace Store.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? Buyer { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
