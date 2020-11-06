using System;

namespace TuplesApp
{
    class Program
    {
        //Tuples before c#.net 7
        //static void Main(string[] args)
        //{
        //    TuplesDemo tuplesDemo = new TuplesDemo();
        //    Tuple<int,int,double> t= tuplesDemo.Math(10, 4);
        //    Console.WriteLine($"Addition {t.Item1}  Multiplication {t.Item2} Division {t.Item3}" );
        //    Console.ReadLine();
        //}

        //Tuples in C#.Net 7.0
        static void Main(string[] args)
        {
            TuplesDemo tuplesDemo = new TuplesDemo();
            var t = tuplesDemo.Math(10, 4);
            Console.WriteLine($"Addition {t.add}  Multiplication {t.mul} Division {t.div}");
            Console.ReadLine();
        }  
    }
}
