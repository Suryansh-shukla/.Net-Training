namespace MVCCoreWebAppDemo1.Models
{
    public class ProductRepo
    {
        public static List<Product> cosmeticProducts = new List<Product>();
        public List<Product> GetAllCosmeticProducts()
        {
            return cosmeticProducts;
        }
    }
}
