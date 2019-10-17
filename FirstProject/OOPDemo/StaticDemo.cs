using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    public class StaticDemo
    {
        public static int Count = 0;
        public string Name = "DEMO!!!";

        public void Increment()
        {
            Count++;
        }

        public void Decrement()
        {
            Count--;
        }
    }
}
