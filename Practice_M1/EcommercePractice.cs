using System;
using System.Collections.Generic;
public class Order
{
    public int OrderId{get;set;}
    public string CustomerName{get; set;}
    public string Item{get; set;}
    public Stack<Order> AddOrderDetails(int orderId, string customerName, string item)
    {
        Program.orderStack.Push(new Order { OrderId = orderId, CustomerName = customerName, Item = item });
        return Program.orderStack;
    }
    public string GetOrderDetails()
    {
        if(Program.orderStack.Count > 0)
        {
            Order recentOrder = Program.orderStack.Peek();
            return $"{recentOrder.OrderId} {recentOrder.CustomerName} {recentOrder.Item}";
        }
        else
        {
            return "No orders in the stack.";
        }
    }
    public Stack<Order> RemoveOrderDetails()
    {
        if(Program.orderStack.Count > 0)
        {
            Program.orderStack.Pop();
        }
        return Program.orderStack;
    }
}
public class Program
{
    public static Stack<Order> orderStack = new Stack<Order>();
    
    public static void Main(string[] args)
    {
        Order order=new Order();
        int n=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<n;i++)
        {
            Console.WriteLine("Enter OrderId, CustomerName and Item:");
            int OrderId=Convert.ToInt32(Console.ReadLine());
            string CustomerName=Console.ReadLine();
            string Item=Console.ReadLine();
            order.AddOrderDetails(OrderId,CustomerName,Item);
        }
        Console.WriteLine(order.GetOrderDetails());
        order.RemoveOrderDetails();
        Console.WriteLine(order.GetOrderDetails());
    }
}