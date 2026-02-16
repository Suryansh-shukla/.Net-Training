using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceInventory
{
    public class InventoryManager
    {
        public void ProcessProducts<T>(IEnumerable<T> products) where T : IProduct
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Processing Product: {product.Name}, Price: {product.Price:C}");

            }
            Console.WriteLine(products.Max(x => x.Price));
            var grouped = products.GroupBy(p => p.category);
            foreach (var group in grouped)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($" - {item.Name}: {item.Price:C}");
                }
            }
            foreach (var product in products)
            {
                if (product.category == Category.Electronics)
                {
                    if (product.Price > 500)
                    {
                        product.Price *= 0.9m; // Apply a 10% discount
                        Console.WriteLine($"Processing Product: {product.Name}, Discounted Price: {product.Price:C}");
                    }
                }
            }
        }
        
        public void UpdatePrices<T>(List<T> products,Func<T,decimal> priceAdjuster)where T:IProduct
        {
            if (products == null || priceAdjuster == null) return;
            foreach (var product in products)
            {
                try
                {
                    decimal newPrice=priceAdjuster(product);
                    if(newPrice<0)
                    {
                        throw new ArgumentException("Prce cannot be negative.");
                    }
                    product.Price = newPrice;
                    Console.WriteLine($"Updated Product: {product.Name}, New Price: {product.Price:C}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine ($"Error updating {product.Name}: {ex.Message}"); 
                }
            }
        }
    }
}
