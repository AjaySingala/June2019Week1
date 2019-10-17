using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    abstract class Vehicle
    {
        public string Color;
        public int NoOfTyres;

        public virtual void Start()
        {
            Console.WriteLine("Color is: " + this.Color);
            Console.WriteLine("No. of Tyres is: " + this.NoOfTyres);
            Console.WriteLine("Starting vehicle...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping vehicle...");
        }
    }
}
