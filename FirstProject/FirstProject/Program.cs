using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int i = 10;
            int j = 20;
            int k = i + j;

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            int age = 19;
            bool isEmployed = true;
            if (age >= 18 && isEmployed)
            {
                Console.WriteLine("An adult and employed");
            }

            Console.WriteLine("i = " + i);
            Console.WriteLine("j = " + j);
            Console.WriteLine("k = " + k);

        }
    }
}
