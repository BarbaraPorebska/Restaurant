using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.domain
{
    public class Chef : Person
    {
        public void PrepareOrders(Waiter waiter) 
        {
            foreach (var order in waiter.Orders)
            {
                order.OrderReady = true;
            }
        }
    }
}
