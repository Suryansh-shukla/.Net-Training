using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create repository
            ProductRepository<IProduct> repository = new ProductRepository<IProduct>();

            // Add Electronic Products
            repository.AddProduct(new ElectronicProduct
            {
                Id = 1,
                Name = "Laptop",
                Price = 75000m,
                Brand = "Dell",
                WarrantyMonths = 24
            });

            repository.AddProduct(new ElectronicProduct
            {
                Id = 2,
                Name = "Headphones",
                Price = 1500m,
                Brand = "Sony",
                WarrantyMonths = 12
            });

            // Add Grocery Products
            repository.AddProduct(new GroceriesProduct
            {
                Id = 3,
                Name = "Rice Bag",
                Price = 600m,
                Brand = "IndiaGate",
                ExpiryDate = DateTime.Now.AddMonths(6),
                Weight = 5
            });

            repository.AddProduct(new GroceriesProduct
            {
                Id = 4,
                Name = "Milk",
                Price = 60m,
                Brand = "Amul",
                ExpiryDate = DateTime.Now.AddDays(7),
                Weight = 1
            });
            
            repository.AddProduct(new BooksProduct
            {
                Id = 5,
                Name = "C# Programming",
                Price = 500m,
                Author = "John Doe",
                ISBN = "123-4567890123"
            });

            repository.AddProduct(new BooksProduct
            {
                Id = 6,
                Name = "Data Structures",
                Price = 400m,
                Author = "Jane Smith",
                ISBN = "456-7890123456"
            });

            repository.AddProduct(new ClothingProduct
                {
                Id = 7,
                Name = "T-Shirt",
                Price = 300m,
                Brand = "Puma"
            });
             repository.AddProduct(new ClothingProduct
            {
                Id = 8,
                Name = "Jeans",
                Price = 1200m,
                Brand = "Levis"
            });
             repository.AddProduct(new DiscountedProduct<IProduct>(
                 new ElectronicProduct
                 {
                     Id = 9,
                     Name = "Smartphone",
                     Price = 50000m,
                     Brand = "Samsung",
                     WarrantyMonths = 18
                 },
                 discountPercentage: 10
             ));
             repository.AddProduct(new DiscountedProduct<IProduct>(
                 new BooksProduct
                 {
                     Id = 10,
                     Name = "Algorithms Book",
                     Price = 800m,
                     Author = "Alice Johnson",
                     ISBN = "789-0123456789"
                 },
                 discountPercentage: 15
             ));
             repository.AddProduct(new DiscountedProduct<IProduct>(
                 new ClothingProduct
                 {
                     Id = 11,
                     Name = "Jacket",
                     Price = 2500m,
                     Brand = "North Face",
                 },
                 discountPercentage: 20
             ));
             repository.AddProduct(new DiscountedProduct<IProduct>(
                 new GroceriesProduct
                 {
                     Id = 12,
                     Name = "Olive Oil",
                     Price = 400m,
                     Brand = "Borges",
                     ExpiryDate = DateTime.Now.AddMonths(12),
                     Weight = 1
                 },
                 discountPercentage: 5
             ));

            // =============================
            // Process Products
            // =============================
            InventoryManager manager = new InventoryManager();

            Console.WriteLine("==== PROCESSING PRODUCTS ====\n");
            manager.ProcessProducts(repository.GetAll());

            // =============================
            // Update Prices (5% Increase)
            // =============================
            Console.WriteLine("\n==== APPLYING 5% PRICE INCREASE ====\n");

            manager.UpdatePrices(
                new List<IProduct>(repository.GetAll()),
                p => p.Price * 1.05m
            );
            // =============================
            // Show Total Inventory Value
            // =============================
            Console.WriteLine("\n==== TOTAL INVENTORY VALUE ====");
            Console.WriteLine(repository.CalculateTotalValue().ToString("C"));

            Console.WriteLine("\n==== PROGRAM FINISHED ====");
            Console.ReadLine();
        }

    }
}
