using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class MyCustomException : Exception
    {
        public MyCustomException()
        {

        }

        public MyCustomException(string phone)
            : base($"Invalid phone number format {phone}")
        {

        }
    }
}
