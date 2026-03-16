namespace ProductManagementDemo.API.Entities
{
    public class InventoryTransaction
    {
        public int Id { get; set; }

        public int InventoryId { get; set; }

        public int QuantityChanged { get; set; }

        public string TransactionType { get; set; } = string.Empty;

        public DateTime TransactionDate { get; set; }

        public virtual Inventory? Inventory { get; set; }
    }
}
