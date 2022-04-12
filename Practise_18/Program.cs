using System;
using ClassLibrary;
namespace Practise_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            {
                order1.ProductCount = 2;
                order1.Price = 12;
                order1.TotalAmount = order1.ProductCount*order1.Price;
                order1.CreatedAt = new DateTime(2020, 1, 1, 0, 0,0);
            }
            Order order2 = new Order();
            {
                order2.ProductCount = 4;
                order2.Price = 3;
                order2.TotalAmount = order2.ProductCount * order2.Price;
                order2.CreatedAt = new DateTime(2021, 1, 1, 0, 0, 0);
            }
            Order order3 = new Order();
            {
                order3.ProductCount = 5;
                order3.Price = 5;
                order3.TotalAmount = order3.ProductCount * order3.Price;
                order3.CreatedAt = new DateTime(2022, 1, 1, 0, 0, 0);
            }
            Shop shop = new Shop(); 
            shop.AddOrder(order1);
            shop.AddOrder(order2);
            shop.AddOrder(order3);


            Console.WriteLine("============================================");
            var dat1 = new DateTime(2019,1, 1, 0, 0, 0);
            Console.WriteLine(shop.GetOrdersAvg(dat1));
            Console.WriteLine("=============================================");
            shop.RemoveByOrderNo(2);
            Console.WriteLine("==============================================");
            foreach (var item in shop.FilterOrderByPrice(0, 20))
            {
                Console.WriteLine(item.No+"-"+item.CreatedAt);
            }    
        }
    }
}
