using System;

namespace DelegateFuncApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate without Return type");
            var delegateMethod = new DelegateClass.DelegateMethod(new Calculator().Addition);
            Print(delegateMethod);
           
            Console.WriteLine("Delegate with Return type");
            var methodWithreturn = new DelegateClass.DelegateMethodWithReturnType(new Calculator().Add);
            int result=methodWithreturn.Invoke(10, 10);
            Console.WriteLine("Add result for return type method" +result);

            Console.WriteLine("........................................");
            Console.WriteLine("Using Action Delegate");
            Action<int, int> action = new Action<int, int>(new Calculator().Addition);
            action(12, 15);

            Console.WriteLine("........................................");
            Console.WriteLine("Using Func Delegate");
            Func<int, int,int> func = new Func<int, int,int>(new Calculator().Add);
            int x= func.Invoke(20, 60);
            Console.WriteLine("result "+x);

            Console.ReadLine();
        }

        private static void Print(DelegateClass.DelegateMethod delegateMethodf)
        {
            delegateMethodf(4, 6);
        }
    }
}
