namespace ProductManagementDemo.API.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public string Status { get; set; } = string.Empty;

        public decimal TotalAmount { get; set; }

        public string PaymentMethod { get; set; } = string.Empty;

        public string ShippingAddress { get; set; } = string.Empty;

        public virtual ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();

    }
}
