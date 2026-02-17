using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceInventory
{
    public class ElectronicProduct
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category =>Category.Electronics;
        public int WarrantyMonths { get; set; } 
        public string Brand { get; set; }

    }
}
