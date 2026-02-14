using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int price { get; set; }
        public int stock { get; set; }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidBookDataException("Price cannot be negative");
                }
                price = value;
            }
        }
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidBookDataException("Stock cannot be negative");
                }
                stock = value;
            }
        }
    }
}
