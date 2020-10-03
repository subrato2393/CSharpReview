using System;

namespace GenericsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> aCalculator = new Calculator<int>(34,89);

            var addition = aCalculator.Add<int>(10, 21);
            aCalculator.Multiply<double>(3.99, 9.6);   
            
            Console.WriteLine("addition "+addition);
          
            
            Console.ReadLine();

        }
    }
}
