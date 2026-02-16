using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceInventory
{
    public interface IProduct
    {
        int ID { get; }
        string Name { get; }
        decimal Price { get; set; }
        Category category { get; }
    }
}
