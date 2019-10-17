using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    class BMW : Car
    {
        public readonly bool GPS;

        public const bool IsValid = true;


        public BMW()
        {
            this.GPS = true;
        }

        public BMW(bool val)
        {
            this.GPS = val;
        }

        //public void SetGPS(bool val)
        //{
        //    this.GPS = val;
        //}
        public override void Start()
        {
            Console.WriteLine("Starting BMW...");
        }
    }

}
