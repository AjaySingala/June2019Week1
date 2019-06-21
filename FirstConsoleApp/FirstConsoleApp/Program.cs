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

            Car myCar = new Car();
            myCar.Color = "Red";
            myCar.NoOfTyres = 4;

            myCar.Start();

            BMW bmw = new BMW();
            bmw.Start();

            Series3 series3 = new Series3();
            series3.foo();

            _3Series s3 = new _3Series();
            s3.Start();
            s3.Accelerate();

            s3.YearOfManufacture = 2018;
            Console.WriteLine(s3.YearOfManufacture);

            Car x = new BMW();
            x.Start();
            ((BMW)x).Accelerate();

            //BMW b = new Car();

            Car c = new Car();
            c.Color = "Green";
            Console.WriteLine(c.Color); // Green.
            RefCar(c);
            Console.WriteLine(c.Color); // Yellow.

            int[] nums = new int[] {1, 2, 3, 4, 5};
            //int[] nums2 = new int[5];
            Console.WriteLine(nums[0]);
            RefArray(nums);
            Console.WriteLine(nums[0]);

            // as Demo
            bmw.Color = "Black";
            Car newCar = bmw as Car;
            bmw.Accelerate();
            Console.WriteLine(newCar.Color);

            //// This does not work.
            //_3Series s3car = bmw as _3Series;
            //s3car.Accelerate();

            Console.Write("Press <ENTER> key to continue...");
            Console.ReadLine();
        }

        private static void RefArray(int[] numbers)
        {
            numbers[0] = 100;
        }

        private static void RefCar(Car c1)
        {
            c1.Color = "Yellow";
        }
    }
}
