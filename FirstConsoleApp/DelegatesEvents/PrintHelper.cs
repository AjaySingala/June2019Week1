using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    // Publisher class.
    public class PrintHelper
    {
        // Delegate.
        public delegate void BeforePrint();

        // Event for the Delegate.
        public event BeforePrint beforePrintEvent;

        public PrintHelper()
        {

        }

        public void PrintNumber(int num)
        {
            // Call delegate method before going to print.
            if(beforePrintEvent != null)
            {
                beforePrintEvent();
            }

            Console.WriteLine("Number: {0:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }
    }
}
