using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    class Car : Vehicle
    {
        public new void Stop()
        {
            Console.WriteLine("Stopping car...");
        }

        public void Accelerate()
        {
            Console.WriteLine("Increasing speed...");
        }

    }
}
