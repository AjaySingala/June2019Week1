using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    // Subscriber.
    public class Number
    {
        private PrintHelper _printHelper;

        private int _value;
        public int Value {
            get { return _value; }
            set { _value = value; }
        }

        public Number(int val)
        {
            _value = val;
            _printHelper = new PrintHelper();
            // Subscribe to the beforePrintEvent event.
            _printHelper.beforePrintEvent += _printHelper_beforePrintEvent;
            _printHelper.beforePrintEvent += newMethod;
        }

        private void newMethod()
        {
            Console.WriteLine("This is the new method");
        }

        // beforePrintEvent event handler.
        private void _printHelper_beforePrintEvent()
        {
            Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }
    }
}
