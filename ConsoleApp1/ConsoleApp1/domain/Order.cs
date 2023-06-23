using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.domain
{
    public class Order
    {
        public Guest Guest { get; set; }
        public string Dish { get; set; }

        public bool OrderReady { get; set; }

        public Order(Guest guest, string dish) 
        {
            Guest = guest;
            Dish = dish;
            OrderReady = false;
        }
    }
}
