using System;
using Models;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ForUnitTesting();
        }

        static void ForUnitTesting()
        {
            Customer cust = new Customer()
            {
                Name = "John",
                City = "New York"
            };

            CustomerBL bl = new CustomerBL();
            bl.Create(cust);

        }
    }
}
