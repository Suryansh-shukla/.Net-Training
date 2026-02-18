using FlexibleInventorySystem_Practice.Interfaces;
using FlexibleInventorySystem_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleInventorySystem_Practice.Services
{  
    public class InventoryManager : IInventoryOperations, IReportGenerator
    {
        private readonly List<Product> _products;
        private readonly object _lockObject = new object();

        public InventoryManager()
        {
            _products = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            if (product == null) return false;
            if (_products.Any(p=>p.Id==product.Id)) return false;
            if(product.Price<=0) return false;
            if(product.Quantity<0) return false;
            _products.Add(product);
            return true;
            //throw new NotImplementedException();
        }

        public Product FindProduct(string productId)
        {
            Product product = null;
            product = _products.Find(p => p.Id == productId);
            if(product == null) return null;
            return product;
             
            //throw new NotImplementedException();
        }

        public string GenerateCategorySummary()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CATEGORY SUMMARY");
            var grouped = _products.GroupBy(p => p.Category);
            foreach (var group in grouped)
            {
                int count=group.Count();
                decimal totalValue=group.Sum(p => p.CalculateValue());
                sb.AppendLine($"{group.Key}:{count} items - Total Value:{totalValue:C}");
            }
            return sb.ToString();
            //throw new NotImplementedException();
        }

        public string GenerateExpiryReport(int daysThreshold)
        {
            throw new NotImplementedException();
        }

        public string GenerateInventoryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("================================");
            sb.AppendLine("INVENTORY REPORT");
            sb.AppendLine("================================");
            sb.AppendLine($"Total Products: {_products.Count}");
            sb.AppendLine($"Total Value: {GetTotalInventoryValue():C}");
            sb.AppendLine();
            sb.AppendLine("Product List:");
            foreach(var item in _products)
            {
                sb.AppendLine($"{item.Id} - {item.Name} - {item.Category} - {item.Quantity} - {item.CalculateValue():C}");
            }

            return sb.ToString();
            //throw new NotImplementedException();
        }

        public string GenerateValueReport()
        {
            List<Product> products = new List<Product>();
            
            throw new NotImplementedException();
        }

        public List<Product> GetLowStockProducts(int threshold)
        {
            List<Product> products = new List<Product>();
            products=_products.Where(p=>p.Quantity < threshold).ToList();
            return products;
            //throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            if (string.IsNullOrEmpty(category)) return new List<Product>();
            
            return _products.Where(p => p.Category == category).ToList();
            //throw new NotImplementedException();
        }

        public decimal GetTotalInventoryValue()
        {

            foreach (Product product in _products)
            {
                decimal value = product.CalculateValue();

            }
            return _products.Sum(p => p.CalculateValue());
            //throw new NotImplementedException();
        }

        public bool RemoveProduct(string productId)
        {
            if (productId == null) return false;
            int removed = _products.RemoveAll(p => p.Id == productId);
            return removed > 0;         
        }

        // Implement all interface methods here

        // Additional methods for bonus features
        public IEnumerable<Product> SearchProducts(Func<Product, bool> predicate)
        {
            return _products.Where(predicate);
        }

        public bool UpdateQuantity(string productId, int newQuantity)
        {
            if(string.IsNullOrEmpty(productId)) { return false; }
            if(newQuantity < 0 ){ return false; }
            var product= _products.Find(p => p.Id == productId);
            if(product==null) { return false; }
            product.Quantity = newQuantity;
            return true;
            //throw new NotImplementedException();
        }

        
    }    
}
