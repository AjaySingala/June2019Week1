using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ECommerce App.");

            Customer customer = new Customer();
            customer.Id = 101;
            customer.Firstname = "John";
            customer.Lastname = "Smith";

            CustomerBL customerBL = new CustomerBL();
            customerBL.Create(customer);

            try
            {
                var cust124 = customerBL.Get(124);
                if (cust124 != null)
                {
                    Console.WriteLine($"Id: {cust124.Id} - Firstname: {cust124.Firstname} - Lastname: {cust124.Lastname}");
                }
                else
                {
                    Console.WriteLine("Record not found...");
                }
            }
            catch(Exception ex)
            {
                // Log it.
                Console.WriteLine("ERROR! " + ex.Message);
            }

            Console.WriteLine("Fetch list of Customers...");
            var customers = customerBL.GetAll();
            foreach(var item in customers)
            {
                Console.WriteLine($"Id: {item.Id} - Firstname: {item.Firstname} - Lastname: {item.Lastname}");
            }

            Customer aCustomer = new Customer()
            {
                Id = 102,
                Firstname = "Mary",
                Lastname = "Jane"
            };

            aCustomer.Email = "abc@xyx.com";

            //Customer cust1 = new Customer(103, "John", "Smith");

            Console.WriteLine("Press <ENTER> to continue...");
            Console.ReadLine();


        }
    }
}
