using ProductManagementDemo.API.DTOs;
using ProductManagementDemo.API.Entities;

namespace ProductManagementDemo.API.Helpers.Extensions
{
    public static class InventoryExtensions
    {
        public static InventoryStatusDto ToStatusDto(this Inventory inventory)
        {
            return new InventoryStatusDto
            {
                QuantityInStock = inventory.QuantityInStock
            };
        }
    }
}
