namespace ProductManagementDemo.API.Entities
{
    public class ProductReview
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; } = string.Empty;

        public bool IsApproved { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual Product? Product { get; set; }

    }
}
