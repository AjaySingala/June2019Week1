using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Car
    {
        public int NoOfTyres;
        public string Color;
        private int Something;

        //private int yearOfManufacture;
        public int YearOfManufacture { get; set; }
        //{
        //    get
        //    { return yearOfManufacture; }

        //    set
        //    {
        //        if(value < 2000)
        //        {
        //            Console.WriteLine("Too old...");
        //        }
        //        else
        //        {
        //            yearOfManufacture = value;
        //        }
        //    }
        //}

        //private int yearOfManufacture;
        //public int YearOfManufacture
        //{
        //    get
        //    {
        //        return yearOfManufacture;
        //    }
        //    set
        //    {
        //        yearOfManufacture = value;
        //    }
        //}

        public void Start()
        {
            Console.WriteLine("Starting car...");
        }
    }
}
