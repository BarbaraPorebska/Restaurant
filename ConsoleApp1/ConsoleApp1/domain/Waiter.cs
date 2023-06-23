using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.domain
{
    public class Waiter : Person
    {
        public List<Order> Orders { get; set; }

        public Waiter()
        {
            Orders = new List<Order>();
        }

        public void TakeOrder(Guest guest, string dish)
        {
            Order order = new Order(guest, dish);
            Orders.Add(order);
        }
    }
}
