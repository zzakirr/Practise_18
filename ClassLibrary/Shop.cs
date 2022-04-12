using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Shop
    {
        List<Order> orders = new List<Order>();
        Order order = new Order();
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
        public double GetOrdersAvg()
        {
            var orderType = typeof(Order);
            double TotalSum = 0;
            int count = 0;
            foreach (var item in orderType.GetProperties())
            {
                Console.WriteLine(item.Name);
                if(item.Name == "TotalAmount")
                {
                    count++;
                    var ordType = item.GetValue(order);
                    TotalSum += (double)ordType;
                }
            }
            return TotalSum/count;
        }
        public double GetOrdersAvg(DateTime dateTime)
        {
            double TotalSum = 0;
            foreach (var item in orders)
            {
                if (item.CreatedAt > dateTime)
                    TotalSum += item.TotalAmount;
                    
            }
            return TotalSum;
        }
        public void RemoveByOrderNo(int no)
        {
            List<Order> newOrders = new List<Order>();
            Predicate<Order> predicate = x => x.No == no;
            foreach (var item in orders)
            {
                if (!predicate(item))
                    newOrders.Add(item);

            }
            orders = newOrders;
        }
        public List<Order> FilterOrderByPrice(double minPrice,double maxPrice)
        {
            List<Order> newOrders =new List<Order>();
            Predicate<Order> predicate = x => x.Price > minPrice && x.Price < maxPrice;
            foreach(var item in orders)
            {
                if (predicate(item))
                    newOrders.Add(item);
            }
            return newOrders;
        }
    }
}
