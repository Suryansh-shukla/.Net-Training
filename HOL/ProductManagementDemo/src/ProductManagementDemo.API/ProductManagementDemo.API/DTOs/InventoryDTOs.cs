namespace ProductManagementDemo.API.DTOs
{
    public class InventoryStatusDto
    {
        public int QuantityInStock { get; set; }
        public bool IsInStock => QuantityInStock > 0;
    }
}
