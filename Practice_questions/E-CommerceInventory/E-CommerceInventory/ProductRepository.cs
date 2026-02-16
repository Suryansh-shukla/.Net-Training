using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceInventory
{
    public enum Category
    {
        Electronics,
        Clothing,
        Books,
        Groceries
    }
    public class ProductRepository<T> where T : class,IProduct
    {
        private List<T> _products = new List<T>();

        private void AddProduct(T product)
        {
            _products.Add(product);
        }

        public IEnumerable<T> FindProducts(Func<T, bool> predicate)
        {
            return _products.Where(predicate);
        }

        public decimal CalculateTotalValue()
        {
            return _products.Sum(p => p.Price);
        }

    }
}
