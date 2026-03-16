namespace ProductManagementDemo.API.DTOs
{
    public class ProductReviewDto
    {
        public string ReviewerName { get; set; } = string.Empty;

        public int Rating { get; set; }

        public string Comment { get; set; } = string.Empty;

    }
}
