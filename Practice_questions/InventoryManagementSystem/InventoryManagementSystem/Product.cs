using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Product<T>
    {
        public string Category { get; set; }
        public bool AddProduct(T item)
        {
            // Implementation to add product to inventory
            return true; // Placeholder return value
        }
    }
}
