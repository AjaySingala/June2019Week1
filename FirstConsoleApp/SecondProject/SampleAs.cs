using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    class BaseClass
    {
        public override string ToString()
        {
            return "BaseClass";
        }
    }

    class DerivedClass : BaseClass
    {
        public override string ToString()
        {
            return "DerivedClass";
        }
    }

    class AnotherClass
    {
        public override string ToString()
        {
            return "AnotherClass";
        }
    }
}
