using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class _3Series : BMW
    {
        public new void Start()
        {
            Console.WriteLine("Starting Series 3 BMS...");
        }

        public void Accelerate()
        {
            Console.WriteLine("Accelerating the Series 3 BMW...");
        }

        void Decelerate()
        {
            Console.WriteLine("Decelerating the Series 3 BMW...");
        }
    }
}
