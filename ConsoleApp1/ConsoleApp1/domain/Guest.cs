using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.domain
{
    public class Guest : Person
    {
        public string Preference { get; set; }

        public bool MakeOrder(Person person)
        {
            if (person is Waiter)
            {
                Waiter waiter = (Waiter)person;
                waiter.TakeOrder(this, Preference);
                return true;
            }    
            else
            {
                return false;
            }


            
        }
    }
}
