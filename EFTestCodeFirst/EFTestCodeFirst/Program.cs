using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Create.
            //CreateCustomer();
            //// Get.
            //GetCustomer(1);

            //// Update.
            //GetCustomer(1);
            //UpdateCustomer(1, "Queens");
            //GetCustomer(1);

            //// Delete.
            //CreateCustomer();
            //GetCustomer(2);
            //UpdateCustomer(2, "Dallas");
            //GetCustomer(2);
            //DeleteCustomer(2);
            GetCustomer(2);
        }

        static void CreateCustomer()
        {
            using (var ctx = new NewDbContext())
            {
                var customer = new Customer()
                {
                    Firstname = "John",
                    Lastname = "Smith",
                    Email = "jsmith@abc.com"
                };

                ctx.Customers.Add(customer);
                ctx.SaveChanges();
            }
        }

        static void GetCustomer(int id)
        {
            using (var ctx = new NewDbContext())
            {
                var customer = ctx.Customers
                    .Where(c => c.Id == id)
                    .SingleOrDefault();

                Console.WriteLine($"{customer.Firstname} {customer.Lastname} {customer.City}");
            }
        }

        static void UpdateCustomer(int id, string city)
        {
            using (var ctx = new NewDbContext())
            {
                var customer = ctx.Customers
                    .Where(c => c.Id == id)
                    .SingleOrDefault();

                customer.City = city;
                ctx.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }


        static void DeleteCustomer(int id)
        {
            using (var ctx = new NewDbContext())
            {
                var customer = ctx.Customers
                    .Where(c => c.Id == id)
                    .SingleOrDefault();

                //ctx.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                ctx.Customers.Remove(customer);
                ctx.SaveChanges();
            }
        }
    }
}
