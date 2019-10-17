using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    class Program
    {
        public delegate void Print(int value);

        static void Main(string[] args)
        {
            #region Code

            //DelegateDemo();
            //MultiCastDelegateDemo();
            EventDemo();
            //RevDelegate();
            //LambdaDemo();
            //PredicateDemo();

            //TestCovar();

            #endregion
        }

        #region Delegate samples

        static void DelegateDemo()
        {
            // Print delegate points to PrintNumber() method.
            Print printDel = PrintNumber;

            // or
            // Print printDel = new Print(PrintNumber);

            printDel(100000);
            printDel(200);

            // Print delegate points to PrintMoney
            printDel = PrintMoney;

            printDel(10000);
            printDel(200);
        }

        static void PrintNumber(int num)
        {
            Console.WriteLine($"Number: {num}");
            //Console.WriteLine("Number: {0,-12:N0}", num);
            Console.WriteLine("Number: {0:N}", num);
            Console.WriteLine("Number: {0:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
            Console.WriteLine("Money: {0:c}", money);
        }

        #region Multicast Delegate

        public delegate void RectDelegate(double height, double width);

        // "Area" method.
        static void Area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

        // "Perimeter" method 
        static void Perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }

        static void MultiCastDelegateDemo()
        {
            RectDelegate rd = new RectDelegate(Area);
            // Call 2nd method Perimeter.
            rd += Perimeter;

            // pass the values in two method by using "Invoke" method.
            rd.Invoke(6.3, 4.2);

            // call the methods with different values 
            rd.Invoke(16.3, 10.3);
        }

        #endregion

        #endregion

        #region Event Samples

        static void EventDemo()
        {
            Number num = new Number(100000);
            num.PrintMoney();
            num.PrintNumber();
        }

        #endregion

        #region Delegate using Func<>

        public delegate string Reverse(string s);

        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }

        static void RevDelegate()
        {
            Reverse rev = ReverseString;
            Console.WriteLine(rev("a string"));

            Func<string, string> rev2 = ReverseString;
            Console.WriteLine(rev2("another string"));
        }

        #endregion

        #region Delegate using Lambda
        
        static void LambdaDemo()
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }

            // Using a direct delegate (Anonymous method). No Lambda.
            Console.WriteLine("Using a direct delegate. No Lambda.");
            List<int> result = list.FindAll(
              delegate (int no)
              {
                  return (no % 2 == 0);
              }
            );

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            // Using a lambda.
            Console.WriteLine("Using a Lambda.");
            List<int> res = list.FindAll(i => i % 2 == 0);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        static void PredicateDemo()
        {
            // Predicate Delegate.
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("hello world!!");
            Console.WriteLine(result);

            // Predicate delegate with anonymous method.
            Predicate<string> isUpper2 = delegate (string s) {
                return s.Equals(s.ToUpper());
            };
            bool result2 = isUpper2("hello world!!");
            Console.WriteLine(result2);

            // Predicate delegate with lambda expression.
            Predicate<string> isUpper3 = s => s.Equals(s.ToUpper());
            bool result3 = isUpper("HELLO WORLD!!");
            Console.WriteLine(result3);
        }

        #region Covariance and Contravariance

        static object GetObject() { return null; }
        static void SetObject(object obj)
        {
            Console.WriteLine(obj);
        }

        static string GetString() { return "Default"; }
        static void SetString(string str)
        {
            Console.WriteLine(str);
        }

        static void TestCovar()
        {

            // Assignment compatibility.   
            string str = "test";
            // An object of a more derived type is assigned to an object of a less derived type.   
            object obj = str;

            // Covariance.   
            IEnumerable<string> strings = new List<string>();
            // An object that is instantiated with a more derived type argument   
            // is assigned to an object instantiated with a less derived type argument.   
            // Assignment compatibility is preserved.   
            IEnumerable<object> objects = strings;

            // Contravariance.             
            // Assume that the following method is in the class:   
            // static void SetObject(object o) { }   
            Action<object> actObject = SetObject;
            // An object that is instantiated with a less derived type argument   
            // is assigned to an object instantiated with a more derived type
            // argument. Assignment compatibility is reversed.   
            Action<string> actString = actObject;

            // Covariance with Delegate.
            // A delegate specifies a return type as object,  
            // but you can assign a method that returns a string.  
            Func<object> del = GetString;
            Console.WriteLine(del.Invoke());

            // Contravariance. A delegate specifies a parameter type as string,  
            // but you can assign a method that takes an object.  
            Action<string> del2 = SetObject;
            del2.Invoke("Hello there!");
        }

        #endregion

    }
}
