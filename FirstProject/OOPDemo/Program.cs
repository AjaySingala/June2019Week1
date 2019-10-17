using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPDemo
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            #region Other deno code.

            //Console.WriteLine("Hello World!");

            //Car myCar = new Car();
            //myCar.Color = "Red";
            //myCar.NoOfTyres = 5;

            //myCar.Start();
            //myCar.Accelerate();
            //myCar.Stop();

            //Car myCar2 = new Car();
            //myCar2.Color = "Yellow";
            //myCar2.NoOfTyres = 4;

            //myCar2.Start();
            //myCar2.Accelerate();
            //myCar2.Stop();

            //BMW bmw1 = new BMW();
            //bmw1.Color = "Blue";
            //bmw1.NoOfTyres = 5;
            //bmw1.Start();
            //bmw1.Accelerate();
            //bmw1.Stop();

            //Console.WriteLine("GPS: " + bmw1.GPS);


            //BMW bmw2 = new BMW(false);
            //Console.WriteLine("GPS: " + bmw2.GPS);

            ////Vehicle veh = new Vehicle();
            ////veh.Accelerate();

            //Add(10, 20);
            //Add(2.5f, 13.45f);

            //Utility.SetValue("Ajay");
            //Console.WriteLine(Utility.GetValue());


            //Document doc = new Document();
            //doc.Name = "Some document";
            //doc.Status = Utility.DocumentStatus.New;

            //// Code...
            //doc.Status = Utility.DocumentStatus.Approved;

            //// Code.
            //if(doc.Status == Utility.DocumentStatus.New)
            //{
            //    Console.WriteLine(doc.Name + " is a new Document");
            //}
            //else if (doc.Status == Utility.DocumentStatus.InProgress)
            //{
            //    Console.WriteLine(doc.Name + " is in progress");
            //}
            //else if (doc.Status == Utility.DocumentStatus.InReview)
            //{
            //    Console.WriteLine(doc.Name + " is waiting for approval");
            //}
            //// Type casting
            //else if (doc.Status == Utility.DocumentStatus.Approved)
            //{
            //    Console.WriteLine(doc.Name + " is Approved");
            //}
            //else if (doc.Status == Utility.DocumentStatus.Rejected)
            //{
            //    Console.WriteLine(doc.Name + " has been Rejected");
            //}

            #endregion

            CreateCustomers();
            ListCustomers();
            ListCustomersForACity("New York");
            ListCustomersForACity("Dallas");
            //CreateData();
            //CountDemo();

            Console.Write("Press <ENTER> to continue...");
            Console.ReadLine();
        }

        static void CountDemo()
        {
            StaticDemo sd = new StaticDemo();
            Console.WriteLine(StaticDemo.Count);
            sd.Increment();
            sd.Increment();
            sd.Increment();
            sd.Name = "SD";
            Console.WriteLine(sd.Name);
            Console.WriteLine(StaticDemo.Count);

            StaticDemo sd2 = new StaticDemo();
            Console.WriteLine(StaticDemo.Count);
            sd2.Increment();
            Console.WriteLine(StaticDemo.Count);
            sd.Decrement();
            Console.WriteLine(StaticDemo.Count);

            sd2.Name = "SD2";
            Console.WriteLine(sd2.Name);



        }

        static void CreateCustomers()
        {
            var cust1 = new Customer()
            {
                Id = 101,
                Firstname = "John",
                City = "New York"
            };
            var cust2 = new Customer()
            {
                Id = 102,
                Firstname = "Mary",
                City = "Reston"
            };
            var cust3 = new Customer()
            {
                Id = 103,
                Firstname = "Joe",
                City = "Dallas"
            };
            var cust4 = new Customer()
            {
                Id = 104,
                Firstname = "Neo",
                City = "New York"
            };
            customers.Add(cust1);
            customers.Add(cust2);
            customers.Add(cust3);
            customers.Add(cust4);

        }

        static void ListCustomersForACity(string city)
        {
            Console.WriteLine($"Listing customers from {city}");
            //foreach(var c in customers)
            //{
            //    if(c.City == city)
            //    {
            //        Console.WriteLine($"Customer Id: {c.Id} Name: {c.Firstname} City: {c.City}");
            //    }
            //}

            // Using LINQ Lambda expressions.
            var custs = customers.Where(c => c.City == city).ToList<Customer>();
            foreach(var cust in custs)
            {
                Console.WriteLine($"Customer Id: {cust.Id} Name: {cust.Firstname} City: {cust.City}");
            }

        }

        static void ListCustomers()
        {
            Console.WriteLine("Customer Orders...");
            foreach (var cust in customers)
            {
                Console.WriteLine($"Customer Id: {cust.Id} Name: {cust.Firstname} City: {cust.City}");
                foreach (var order in cust.Orders)
                {
                    Console.WriteLine($"Order Id: {order.Id}");
                }
            }
        }
        static void CreateData()
        {
            
            //ListCustomers();

            //var products = new List<Product>()
            //{
            //    new Product { Id = 201, Name = "Pen", Price = 2 },
            //    new Product { Id = 202, Name = "Pencil", Price = 1 },
            //    new Product { Id = 203, Name = "Paper", Price = 4 }
            //};

            //Console.WriteLine("Products...");
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"Product Id: {product.Id} Name: {product.Name}");
            //}

            //var ord1 = new Order()
            //{
            //    Id = 501,
            //    CustomerId = 101,
            //    Customer = cust1
            //};

            //if (cust1.Orders == null)
            //{
            //    cust1.Orders = new List<Order>();
            //}
            //cust1.Orders.Add(ord1);

            //ListCustomers();
        }

        static void Add(int i, int j)
        {
            int x = i + j;
            Console.WriteLine("Adding integers: " + x);
        }

        static void Add(float i, float j)
        {
            float x = i + j;
            Console.WriteLine("Adding floats: " + x);
        }
    }
}
