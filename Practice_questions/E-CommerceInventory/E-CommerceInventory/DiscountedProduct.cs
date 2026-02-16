using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceInventory
{
    public class DiscountedProduct<T> where T : IProduct
    {
        private T _product;
        private decimal _discountPercentage;

        public DiscountedProduct(T product, decimal discountPercentage)
        {
            // TODO: Initialize with validation
            // Discount must be between 0 and 100
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            }
            if (discountPercentage < 0 || discountPercentage > 100)
            {
                throw new ArgumentOutOfRangeException("Discount percentage must be between 0 and 100.");
            }
            _product = product;
            _discountPercentage=discountPercentage;
        }

        // TODO: Implement calculated price with discount
        public decimal DiscountedPrice => _product.Price * (1 - _discountPercentage / 100);


        // TODO: Override ToString to show discount details
        public override string ToString()
        {
            return $"{_product.Name} - Original Price: {_product.Price:C}, Discount: {_discountPercentage}%, Final Price: {DiscountedPrice:C}";
        }
    }

}
