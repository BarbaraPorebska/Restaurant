using Restaurant.domain;

namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guest guest1 = new Guest
            {
                ID = 1,
                Name = "Ania",
                Preference = "Salad"
            };

            Guest guest2 = new Guest
            {
                ID = 2,
                Name = "Tomek",
                Preference = "Fries"
            };

            Guest guest3 = new Guest
            {
                ID = 3,
                Name = "Adam",
                Preference = "Burgir"
            };

            Waiter waiter1 = new Waiter 
            {
                ID = 4,
                Name = "Bolek"
            };

            Chef chef = new Chef
            {
                ID = 5,
                Name = "Zbigniew"
            };

            if (!guest1.MakeOrder(chef))
            {
                Console.WriteLine("Order not made");
            }
            if (!guest1.MakeOrder(waiter1))
            {
                Console.WriteLine("Order not made");
            }
            if (!guest2.MakeOrder(waiter1))
            {
                Console.WriteLine("Order not made");
            }
            if (!guest3.MakeOrder(waiter1))
            {
                Console.WriteLine("Order not made");
            }


            chef.PrepareOrders(waiter1);

            Console.ReadLine();
        }
    }
}