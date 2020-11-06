using System;

namespace TuplesLatestDotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Math(10, 4));
            Console.ReadLine();
        }
    }
}
