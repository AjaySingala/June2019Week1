using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        public void Create(Customer newCustomer)
        {
            // Connect to the DB and create a new record.
        }

        public Customer Get(int id)
        {
            try
            {
                // Connect to DB, search for record with matching id.
                Customer cust = new Customer()
                {
                    Id = id,
                    Firstname = "Fred",
                    Lastname = "Smith"
                };

                //throw new Exception("Cannot connect to the Database.");
                throw new MyCustomException("This is my custom exception.");

                return cust;
            }
            catch(Exception ex)
            {
                // Log the details of the exception.
                throw;
                //return null;
            }
        }

        public List<Customer> GetAll()
        {
            // Connect to the DB and fetch all Customer records.
            List<Customer> customerList = new List<Customer>()
            {
                new Customer { Id=101, Firstname="John", Lastname="Smith" },
                new Customer { Id=102, Firstname="Mary", Lastname="Jane" },
                new Customer { Id=103, Firstname="Fred", Lastname="Smith" },
                new Customer { Id=104, Firstname="Neo", Lastname="Anderson" },
                new Customer { Id=105, Firstname="Ajay", Lastname="Singala" }
            };

            return customerList;

            //List<Customer> customerList = new List<Customer>();

            //Customer c1 = new Customer()
            //{
            //    Id = 101,
            //    Firstname = "John",
            //    Lastname = "Smith"
            //};
            //customerList.Add(c1);

            //Customer c2 = new Customer()
            //{
            //    Id = 102,
            //    Firstname = "Mary",
            //    Lastname = "Jane"
            //};
            //customerList.Add(c2);

            //Customer c3 = new Customer()
            //{
            //    Id = 103,
            //    Firstname = "Fred",
            //    Lastname = "Smith"
            //};
            //customerList.Add(c3);

            //Customer c4 = new Customer()
            //{
            //    Id = 104,
            //    Firstname = "Neo",
            //    Lastname = "Anderson"
            //};
            //customerList.Add(c4);

            //Customer c5 = new Customer()
            //{
            //    Id = 105,
            //    Firstname = "Ajay",
            //    Lastname = "Singala"
            //};
            //customerList.Add(c5);

            //return customerList;
        }
    }
}
