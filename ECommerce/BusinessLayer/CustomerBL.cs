using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerBL
    {
        public void Create(Customer newCustomer)
        {
            // Call the DAL to create a new record.
            CustomerDAL customerDAL = new CustomerDAL();
            customerDAL.Create(newCustomer);
        }

        public Customer Get(int id)
        {
            CustomerDAL dal = new CustomerDAL();
            try
            {
                var customer = dal.Get(id);
                if (customer != null)
                {
                    // Data found. Process it and return to UI.
                    return customer;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                // Log it.
                throw;
            }
        }

        public List<Customer> GetAll()
        {
            CustomerDAL dal = new CustomerDAL();
            var customers = dal.GetAll();

            return customers;
        }
    }
}
