using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MyCustomException : Exception
    {
        public MyCustomException()
        {
            
        }

        public MyCustomException(string msg) : base(msg)
        {

        }
    }
}
