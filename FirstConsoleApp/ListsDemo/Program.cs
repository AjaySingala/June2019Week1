using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsDemo
{
    //class Product
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            CreateCustomers();
            PrintCustomers();
        }

        static void CreateCustomers()
        {
            //Product prod1 = new Product();
            //prod1.Id = 1;
            //prod1.Name = "Laptop";

            //customers.Add(prod1);

            //var customerList = new List<Customer>();

            var customer = new Customer();
            customer.Id = 101;
            customer.Firstname = "John";
            customer.Lastname = "Smith";
            customers.Add(customer);

            Customer customer2 = new Customer();
            customer2.Id = 102;
            customer2.Firstname = "Mary";
            customer2.Lastname = "Jane";
            customers.Add(customer2);
        }

        static void PrintCustomers()
        {
            //for(int i = 0; i < customers.Count; i++)
            //{
            //    Console.WriteLine(customers[i].Lastname + ", " + customers[i].Firstname);
            //}
            foreach(var item in customers)
            {
                Console.WriteLine(item.Lastname);
            }
        }
    }
}
