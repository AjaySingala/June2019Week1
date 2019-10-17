using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arrx = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(arrx[0]);

            //MultiDimArrayDemo();
            //DictionaryDemo();

            //ExceptionHandlingDemo();
            //CustomExceptionDemo();
            //ThrowDemo();

            //ArrayOfCars();

            //int l = 5;
            //int[] nu = new int[l];
            //nu[0] = 10;

            //Car myCar = new Car();
            //myCar.Color = "Red";
            //myCar.NoOfTyres = 4;

            //myCar.Start();

            //BMW bmw = new BMW();
            //bmw.Start();

            //Series3 series3 = new Series3();
            //series3.foo();

            //_3Series s3 = new _3Series();
            //s3.Start();
            //s3.Accelerate();

            //s3.YearOfManufacture = 2018;
            //Console.WriteLine(s3.YearOfManufacture);

            //Car x = new BMW();
            //x.Start();
            //((BMW)x).Accelerate();

            ////BMW b = new Car();

            //Car c = new Car();
            //c.Color = "Green";
            //Console.WriteLine(c.Color); // Green.
            //RefCar(c);
            //Console.WriteLine(c.Color); // Yellow.

            //int[] nums = new int[] {1, 2, 3, 4, 5};
            ////int[] nums2 = new int[5];
            //Console.WriteLine(nums[0]);
            //RefArray(nums);
            //Console.WriteLine(nums[0]);

            //// as Demo
            //bmw.Color = "Black";
            //Car newCar = bmw as Car;
            //bmw.Accelerate();
            //Console.WriteLine(newCar.Color);

            ////// This does not work.
            ////_3Series s3car = bmw as _3Series;
            ////s3car.Accelerate();

            Console.Write("Press <ENTER> key to continue...");
            Console.ReadLine();
        }

        static void MultiDimArrayDemo()
        {
            int[,] numbers =
            {
                { 1,2,3,4 },
                { 5,6,7,8 },
                { 9,10,11,12 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.WriteLine(numbers[i, j]);
            }
        }

        static void DictionaryDemo()
        {
            var cars = new Dictionary<int, Car>();
            //var c1 = new Car();
            //c1.Color = "Red";
            //var c2 = new Car();
            //c2.Color = "Yellow";
            //var c3 = new Car();
            //c3.Color = "Green";

            var c1 = new Car()
            {
                Color = "Red",
                NoOfTyres = 5,
                YearOfManufacture = 2018
            };

            var c2 = new Car()
            {
                Color = "Yellow",
                NoOfTyres = 5,
                YearOfManufacture = 2018
            };

            var c3 = new Car()
            {
                Color = "Blue",
                NoOfTyres = 5,
                YearOfManufacture = 2018
            };


            cars.Add(1, c1);
            cars.Add(2, c2);
            cars.Add(3, c3);

            foreach (var car in cars)
            {
                Console.WriteLine(car.Value.Color);
            }
        }

        private static void RefArray(int[] numbers)
        {
            numbers[0] = 100;
        }

        private static void RefCar(Car c1)
        {
            c1.Color = "Yellow";
        }

        static void ArrayOfCars()
        {
            Car[] cars = new Car[2];
            cars[0] = new Car();
            cars[1] = new BMW();
            foreach (var car in cars)
            {
                if (car is BMW)
                {
                    ((BMW)car).Accelerate();
                }
            }
        }

        #region Exception Handling Demos

        static void ExceptionHandlingDemo()
        {
            try
            {
                int i = 10;
                int j = 0;
                int k = i / j;
                Console.WriteLine($"{i} - / {j} = {k}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR! Unable to process request");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void ExceptionHandlingDemo2()
        {
            try
            {
                // Connect to database. Open connection.
                // Read a table for records
                // Process each record in the table.
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR! Unable to process request");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.StackTrace);
                throw;
            }
            //finally
            //{
                // Close DB Connection.
            //}
        }

        static void CustomExceptionDemo()
        {
            // Registration page. Accept phone number.
            var phone = "@#$123";
            if (phone != "12345567890")
            {
                throw new MyCustomException(phone);
            }
        }

        static void ThrowDemo()
        {
            try
            {
                CallA();
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR in ThrowDemo()...");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void CallA()
        {
            CallB();
        }

        static void CallB()
        {
            try
            {
                int i = 10;
                int j = 0;
                int k = i / j;
                Console.WriteLine(k);
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR in CallB()...");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }

        #endregion
    }
}
