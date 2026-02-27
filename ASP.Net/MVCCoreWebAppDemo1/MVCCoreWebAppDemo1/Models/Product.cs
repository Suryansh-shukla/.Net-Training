using System.Globalization;

namespace MVCCoreWebAppDemo1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal COst { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public int StockQuatity { get; set; }
    }
}
