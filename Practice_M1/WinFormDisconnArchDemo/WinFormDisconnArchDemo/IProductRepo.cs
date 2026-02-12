using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDisconnArchDemo
{
    public interface IProductRepo : IRepo<Product>
    {
        List<Product> ShowAllProductByCategory(int catID);
        List<Product> ShowProductByPriceAsc();
        List<Product> ShowProductByPriceDesc();
        List<Product> GetTop3CostlyProduct();
        List<Product> GetTop3BudgetProduct();

    }
}
