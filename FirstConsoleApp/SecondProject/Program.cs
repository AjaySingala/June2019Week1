using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //BoxingDemo();
            //AsDemo();
            OutRefDemo();
            //DictionaryDemo();

            // This to be covered after delegates and events.
            //CoVarDemo();
        }

        static void BoxingDemo()
        {
            // Boxing: implicit conversion of a value type 
            // to the type "object".
            int i = 123;
            object o = i;   // Boxes i
            Console.WriteLine($"{i} and {o}");

            // Unboxing: explicit conversion from the type "object"
            // to a value type.
            o = 140;
            i = (int)o;     // Unboxing
            Console.WriteLine($"{i} and {o}");
        }

        static void AsDemo()
        {
            object[] array = new object[] {
                new BaseClass(),
                new DerivedClass(),
                new AnotherClass()
            };

            //BaseClass x = (BaseClass)array[2];

            for (int i = 0; i < array.Length; i++)
            {
                BaseClass b = array[i] as BaseClass;

                if (b != null)
                {
                    Console.WriteLine("{0}: {1}", i, b);
                }
                else
                {
                    Console.WriteLine("{0}: null", i);
                }
            }
        }

        #region out and ref

        static void OutRefDemo()
        {
            // Out demo.
            int num;
            Sum(out num);
            Console.WriteLine($"Sum of the value is: {num}");

            // Ref demo.
            string str = "Hello";
            Console.WriteLine($"Before: {str}");
            SetValue(ref str);
            Console.WriteLine($"After: {str}");

            Console.WriteLine(typeof(string));
            Console.WriteLine(str.GetType());

            String name = "John";
            Console.WriteLine($"Before {name}");
            ChangeName(ref name);
            Console.WriteLine($"After {name}");

        }

        static void ChangeName(ref String str)
        {
            str = "Smith";
        }

        static void Sum(out int val)
        {
            val = 25;
            val += 25;
        }

        static void SetValue(ref string s)
        {
            s = "Hello there!";
        }

        #endregion

        static void DictionaryDemo()
        {
            Dictionary<int, string> dc1 = new Dictionary<int, string>();
            dc1.Add(1, "One");
            dc1.Add(2, "Two");
            dc1.Add(3, "Tri");

            //foreach(var item in dc1)
            //foreach(KeyValuePair<int, string> item in dc1)
            foreach (var item in dc1)
                {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
                Console.WriteLine("Key: {0}. Value: {1}", item.Key, item.Value);
                Console.WriteLine($"Key: {item.Key}. Value: {item.Value}");
            }
        }

        #region CoVariance and ContraVariance
        
        static void SetObject(object o)
        {
            Console.WriteLine($"Inside SetObject: {o}");
        }

        static void CoVarDemo()
        {
            // Assignment compatibility.
            string str = "test";
            // An object of a more derived type is assigned 
            // to an object of a less derived type.   
            object obj = str;
            Console.WriteLine($"{obj} and {str}");

            // Covariance.   
            IEnumerable<string> strings = new List<string>();
            // An object that is instantiated with a more derived type 
            // argument is assigned to an object instantiated with a 
            // less derived type argument.
            // Assignment compatibility is preserved.   
            IEnumerable<object> objects = strings;
            Console.WriteLine($"{objects} and {strings}");

            // Contravariance.
            // Usually used with delegates.
            // Assume that the following method is in the class:   
            // static void SetObject(object o) { }   
            Action<object> actObject = SetObject;
            // An object that is instantiated with a less derived type
            // argument is assigned to an object instantiated with a
            // more derived type argument.   
            // Assignment compatibility is reversed.   
            Action<string> actString = actObject;
            actObject.Invoke("hello");
        }

        #endregion
    }
}
