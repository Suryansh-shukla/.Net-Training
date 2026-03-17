using System.ComponentModel.DataAnnotations;
using ProductManagementDemo.API.Validators;

namespace ProductManagementDemo.API.DTOs
{
    public class ProductDTOs
    {

    }

    public class ProductDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal? DiscountedPrice { get; set; }

        // Computed properties — calculated from other fields, never stored
        public decimal Savings => Price - (DiscountedPrice ?? Price);
        public int DiscountPercentage => DiscountedPrice.HasValue
            ? (int)((Price - DiscountedPrice.Value) / Price * 100) : 0;

        public CategoryBasicDto Category { get; set; } = new();
        public SupplierBasicDto? Supplier { get; set; }
        public InventoryStatusDto? Inventory { get; set; }

        public bool IsActive { get; set; }
        public bool IsFeatured { get; set; }
        public double AverageRating { get; set; }
        public int ReviewCount { get; set; }

        public string Sku { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new();
        public Dictionary<string, string> Specifications { get; set; } = new();
        public List<ProductAttributeDto> Attributes { get; set; } = new();
        public List<ProductReviewDto> RecentReviews { get; set; } = new();
    }

    // Lightweight summary — used in lists, search results, carousels
    public class ProductSummaryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public double AverageRating { get; set; }
        public int ReviewCount { get; set; }
        public bool IsInStock { get; set; }
    }
    public class CreateProductDto
    {
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Range(0, double.MaxValue)]
        [CompareWith("Price", IsLessThan = true,ErrorMessage = "Discounted price must be less than regular price")]
        public decimal? DiscountedPrice { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z0-9-]+$",ErrorMessage = "SKU must be uppercase letters, numbers, and hyphens only")]
        [StringLength(50)]
        public string Sku { get; set; } = string.Empty;

        [Url(ErrorMessage = "Invalid image URL format")]
        public string ImageUrl { get; set; } = string.Empty;

        public List<string> Tags { get; set; } = new();
        public Dictionary<string, string> Specifications { get; set; } = new();
    }
    public class UpdateProductDto
    {
        // All properties are nullable — only provided fields get updated
        [StringLength(100, MinimumLength = 3)]
        public string? Name { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal? Price { get; set; }

        public decimal? DiscountedPrice { get; set; }
        public int? CategoryId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsFeatured { get; set; }

        [Url]
        public string? ImageUrl { get; set; }

        public List<string>? Tags { get; set; }
        public Dictionary<string, string>? Specifications { get; set; }
    }
    public class ProductFilterDto
    {
        public string? SearchTerm { get; set; }
        public int? CategoryId { get; set; }
        public List<int>? CategoryIds { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public bool? IsOnSale { get; set; }
        public bool? InStock { get; set; }
        public bool? IsFeatured { get; set; }
        public int? MinRating { get; set; }
        public List<string>? Tags { get; set; }
        public string? SortBy { get; set; }  // Price | Name | Rating | Newest | Popular
        public bool SortDescending { get; set; } = false;
    }

    // Generic pagination envelope used by all list endpoints
    public class PagedResultDto<T>
    {
        public List<T> Items { get; set; } = new();
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPrevious => PageNumber > 1;
        public bool HasNext => PageNumber < TotalPages;
    }


}
