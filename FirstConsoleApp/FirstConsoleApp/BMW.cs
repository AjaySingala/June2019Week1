using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class BMW : Car
    {
        public new void Start()
        {
            Console.WriteLine("Starting BMW...");
        }
        public void Accelerate()
        {
            Console.WriteLine("BMW Accelerating...");
        }

        protected void TurnLeft()
        {
            Console.WriteLine("BMW turning left...");
        }
    }

    class Series3 : BMW
    {
        public void foo()
        {
            TurnLeft();
        }
    }
}
