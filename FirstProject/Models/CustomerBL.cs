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
            var id = 0;
            if (_customers.Count != 0)
            {
                id = _customers.Max(c => c.Id);
            }
            id++;

            customer.Id = id;
            _customers.Add(customer);

            return customer;
        }
    }
}
