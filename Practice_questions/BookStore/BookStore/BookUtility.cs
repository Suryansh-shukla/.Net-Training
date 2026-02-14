using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookUtility
    {
        Book book;
        public BookUtility(Book book) 
        {
            this.book = book;
        }
        public void GetBookDetails(Book book)
        {
            Console.WriteLine("Details: "+book.ID+" "+book.Title+" "+book.Price+" "+book.Stock);
        }
        public void UpdateBookPrice(int newPrice)
        {
            book.Price = newPrice;
            Console.WriteLine("Updated Price: " + newPrice);
        }
        public void UpdateBookStock(int newStock)
        {
            book.Stock = newStock;
            Console.WriteLine("Updated Stock: " + newStock);
        }
    }
}
