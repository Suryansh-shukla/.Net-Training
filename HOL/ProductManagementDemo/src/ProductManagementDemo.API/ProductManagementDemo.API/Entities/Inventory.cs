namespace ProductManagementDemo.API.Entities
{
    public class Inventory
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int QuantityInStock { get; set; }

        public int ReorderLevel { get; set; }

        public string WarehouseLocation { get; set; } = string.Empty;

        public virtual Product? Product { get; set; }

        public virtual ICollection<InventoryTransaction> Transactions { get; set; } = new List<InventoryTransaction>();

    }
}
