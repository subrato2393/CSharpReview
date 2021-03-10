using System;

namespace RefAndOutApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2;
            GetValue(ref number1);
            GetValueForOutKey(out number2);
            Console.WriteLine("Main method value "+number1);
            Console.ReadLine();
        }
        static void GetValue(ref int number)
        {
            number++;
            Console.WriteLine("Get value method "+number);
        }
        static void GetValueForOutKey(out int number)
        {
            number = 10;
            number++;
            Console.WriteLine("Out number "+number);
        }
    }
}
