using System;

namespace TuplesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TuplesDemo tuplesDemo = new TuplesDemo();
            Tuple<int,int,double> t= tuplesDemo.Math(10, 4);
            Console.WriteLine($"Addition {t.Item1}  Multiplication {t.Item2} Division {t.Item3}" );
            Console.ReadLine();
        }

        //Return Two Value from a method
        
    }
}
