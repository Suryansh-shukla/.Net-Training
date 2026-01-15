using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp7_NewFeatures
{
    class Product
    {
        Dictionary<int, decimal> productPriceList = new Dictionary<int, decimal>();
        public int ProductId { get; set; } = 1;
        public decimal Price //Expression bodied getter-setter
        {
            get => productPriceList[ProductId];
            set => productPriceList[ProductId] = value;
        }
        public string Description { get => description; set => description = value; }

        string description;



       public Product() => Price = 4000; //Expression bodied constructor
        ~Product() => Console.WriteLine("Expression bodied destructor");
    }
    class ExpressionBodiedMembers
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Console.WriteLine($"Price {p.Price}");
            ExpressionBodiedMembers ev = new ExpressionBodiedMembers();
            ValueTask<int> res = ev.CallMe();
            Console.WriteLine(res);


            Console.ReadKey();
        }
        public async ValueTask<int> CallMe()
        {
            Console.WriteLine("Calling CallMe Function");
            int temp = await Calculate();
            Console.WriteLine("Inside CallMe Function");
            return temp;
        }

        private async Task<int> Calculate()
        {
            int total=0;
            for (int i = 1; i <= 15; i++)
            {
                total += i;
                Thread.Sleep(500);
            }
            return total;
        }
    }
   
}
