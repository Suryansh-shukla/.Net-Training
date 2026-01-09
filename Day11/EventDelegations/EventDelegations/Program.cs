using System;
namespace EventDelegations
{
    public delegate bool CreateRecord(Product p);
    public delegate void Caller(string str);
    class Program
    {
        public static void ShowMe(string str)
        {
            Console.WriteLine("Show Me Called...",str); 
        }

        public static void GenerateBill(string str)
        {
            Console.WriteLine("Generate Bill Called",str);
        }
        public static void Main(string[] args)
        {
            //ProductRepo pRepo = new ProductRepo();
            //CreateRecord AddProduct = new CreateRecord(pRepo.Add);
            //AddProduct(new Product());
            Caller CallMe=new Caller(Program.ShowMe);
            CallMe += new Caller(Program.GenerateBill); // Use type name for static method
            CallMe("LPU");
        }
    }
}