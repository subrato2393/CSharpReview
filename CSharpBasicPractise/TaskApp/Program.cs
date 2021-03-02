using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskApp
{
    class Program
    {
       //public delegate void DelegateMethod();
        static void Main(string[] args)
        {
            Console.WriteLine($"Main thread : {Thread.CurrentThread.ManagedThreadId} started");

            //Task task = new Task(PrintCounter);
            //task.Start();

            //Task task1 = Task.Run(() =>
            //{
            //    PrintCounter();
            //});

              Task<string> task = Task.Run(() =>
              {
                 return GetValue("subroto");
              });
             Console.WriteLine(task.Result);
           
            
            //Task task1 = new Task(PrintCounter1);
            //task1.Start(); 
         
            //method call using delegate
            //DelegateMethod del = new DelegateMethod(PrintCounter);
            //PrintCounter();
            Console.WriteLine($"Main thread : {Thread.CurrentThread.ManagedThreadId} stop");
            
            Console.ReadLine();
        }

        private static void PrintCounter()
        {
            Console.WriteLine($"Child thread : {Thread.CurrentThread.ManagedThreadId} started");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Count value {i}");
            }
            Console.WriteLine($"Child thread : {Thread.CurrentThread.ManagedThreadId} stop");
        }
        public static string GetValue(string x)
        {
            Console.WriteLine($"Child thread : {Thread.CurrentThread.ManagedThreadId} started");
            return x;
        }
        private static void PrintCounter1()
        {
            Console.WriteLine($"Child thread : {Thread.CurrentThread.ManagedThreadId} started");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Count value {i}");
            }
            Console.WriteLine($"Child thread : {Thread.CurrentThread.ManagedThreadId} stop");
        }
    }
}
