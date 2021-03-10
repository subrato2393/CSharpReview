using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsyncApp
{
    class Program
    {
        static void  Main(string[] args) 
        {
            Console.WriteLine($"Thread id {Thread.CurrentThread.ManagedThreadId}");
        
            Task task =  Task.Run(() =>
            {
                var coffe = MakeCoffe();
                Console.WriteLine("Coffe is ready");
            });

            Task task1 = Task.Run(() =>
            {
                var egg = FryEgg();
                Console.WriteLine("Egg is ready to eat");

            });

            Task task2 = Task.Run(() =>
            {
                var chicken = WarmUpChicken();
                Console.WriteLine("Chicken is ready");
            });

            Console.WriteLine("Your breakfirst is Ready to eat");
            Console.ReadLine();
        }
        private async static Task<Chicken> WarmUpChicken()
        {
            Console.WriteLine($"Thread id {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Put chicken on heater");
            await Task.Delay(2000);
            Console.WriteLine("Heat Chicken");
            return new Chicken();
        }
        private async static Task<Egg> FryEgg()
        {
            Console.WriteLine($"Thread id {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Warming the egg pan and oil");
            await Task.Delay(2000);
            Console.WriteLine("Fry Egg");
            return new Egg(); 
        }
        private async static Task<Coffe> MakeCoffe()
        {
            Console.WriteLine($"Thread id {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Heat water for coffe");
            await Task.Delay(2000);
            Console.WriteLine("Mix coffe and sugar to water when water warm");
            return new Coffe();
        }
    }
}
