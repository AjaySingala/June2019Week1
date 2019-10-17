using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test();
        }

        static Coffee PourCoffee()
        {
            return new Coffee();
        }

        static async Task<Egg> FryEggs(int eggs)
        {
            Console.WriteLine("Frying eggs...");
            Thread.Sleep(1000);
            return new Egg();
        }

        static async Task<Bacon> FryBacon(int bacons)
        {
            Console.WriteLine("Frying bacon...");
            Thread.Sleep(1000);
            return new Bacon();
        }

        static async Task<Toast> ToastBread(int breads)
        {
            Console.WriteLine("Toasting bread...");
            Thread.Sleep(1000);
            return new Toast();
        }

        static void ApplyButter(Toast toast)
        {
        }

        static void ApplyJam(Toast toast)
        {
        }

        static Juice PourOJ()
        {
            return new Juice();
        }

        // async = Asynchronous
        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBread(number);
            ApplyButter(toast);
            ApplyJam(toast);
            return toast;
        }

        static async void Test()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");
            Task<Egg> eggTask = FryEggs(2);
            Task<Bacon> baconTask = FryBacon(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            //Task<Toast> toastTask = ToastBread(2);
            //Toast toast = await toastTask;
            //ApplyButter(toast);
            //ApplyJam(toast);
            //Console.WriteLine("toast is ready");
            //Juice oj = PourOJ();
            //Console.WriteLine("juice is ready");

            Egg eggs = await eggTask;
            Console.WriteLine("eggs are ready");
            Bacon bacon = await baconTask;
            Console.WriteLine("bacon is ready");
            var toast = await toastTask;
            Console.WriteLine("toast is ready");
            Juice oj = PourOJ();
            Console.WriteLine("juice is ready");

            Console.WriteLine("Breakfast is ready!");
        }
    }
}
