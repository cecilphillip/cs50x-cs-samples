using System;
using CS50xWeek4.Models;

namespace CS50xWeek4
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new NorthwindEntities())
            {
                foreach (var cust in ctx.Customers)
                {
                    Console.WriteLine("Customer Info: ");
                    Console.WriteLine("Customer Name: " + cust.ContactName);
                    Console.WriteLine("Customer Address: " + cust.Address);
                    Console.WriteLine("Order Count: " + cust.Orders.Count);
                    foreach (var order in cust.Orders)
                    {
                        Console.WriteLine("Order Date:" + order.OrderDate);
                    }
                }
            }

            Console.Read();
        }
    }
}
