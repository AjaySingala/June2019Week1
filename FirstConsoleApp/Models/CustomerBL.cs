using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Models
{
    public class CustomerBL
    {
        static List<Customer> _customers = new List<Customer>();

        public Customer Create(Customer customer)
        {
            var id = _customers.Max(c => c.Id) + 1;
            customer.Id = id;
            _customers.Add(customer);

            return customer;
        }
    }
}
