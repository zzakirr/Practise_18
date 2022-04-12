using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Order
    {
        static int _no = 0;
        public Order()
        {
            _no++;
            No = _no;
        }
        public int No { get; set; }
        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
