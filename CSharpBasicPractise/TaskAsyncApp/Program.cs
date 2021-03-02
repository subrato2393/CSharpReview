using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsyncApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffe coffe = MakeCoffe();
            Console.WriteLine("Coffe is ready");

            Console.WriteLine("----------------->>");

            Egg egg = FryEgg();
            Console.WriteLine("Egg is ready to eat");

            Console.WriteLine("----------------->>");

            Chicken chicken = WarmUpChicken();
            Console.WriteLine("Chicken is ready");

            Console.WriteLine("----------------->>");

            Console.WriteLine("Your breakfirst is Ready to eat");
            Console.ReadLine();
        }
        private static Chicken WarmUpChicken()
        {
            Console.WriteLine("Put chicken on heater");
            Task.Delay(2000).Wait();
            Console.WriteLine("Heat Chicken");
            return new Chicken();
        }
        private static Egg FryEgg()
        {
            Console.WriteLine("Warming the egg pan and oil");
            Task.Delay(2000).Wait();
            Console.WriteLine("Fry Egg");
            return new Egg();
        }
        private static Coffe MakeCoffe()
        {
            Console.WriteLine("Heat water for coffe");
            Task.Delay(2000).Wait();
            Console.WriteLine("Mix coffe and sugar to water when water warm");
            return new Coffe();
        }
    }
}
