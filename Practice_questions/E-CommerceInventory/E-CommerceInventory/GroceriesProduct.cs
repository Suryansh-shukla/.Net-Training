using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceInventory
{
    public class GroceriesProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category => Category.Groceries;
        public DateTime ExpiryDate { get; set; }
        public string Brand { get; set; }
        public double Weight { get; set; }

    }
}
