using System;

namespace ExtensionMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int add= calculator.Add(4, 6);
            int sub= calculator.Subtract(10, 4);
            calculator.Print();

            Console.WriteLine("Add "+add);
            Console.WriteLine("Subtract "+sub);
            Console.ReadLine();
        }
    }
}
