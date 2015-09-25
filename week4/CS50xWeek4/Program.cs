using System;
using System.Linq;
using CS50xWeek4.Models;

namespace CS50xWeek4
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new NorthwindEntities())
            {
                var firstOne = ctx.Shippers.First();

                Console.WriteLine(firstOne.CompanyName);
                firstOne.CompanyName = "some other company name";

                ctx.SaveChanges();
                Console.WriteLine(firstOne.CompanyName);
            }

            Console.Read();
        }
    }
}
