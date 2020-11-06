using System;

namespace TupleBasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create instance of Tuple Class
            //var tuple= new Tuple<string, int, int>("subroto", 25, 7);
            //var a=tuple.Item1+" "+tuple.Item2+" "+tuple.Item3;

            // Using helper method Create() which return the instance of the Tuple
            //var tuple = Tuple.Create<string, int, int>("subroto", 26, 7);
            //var a = tuple.Item1 + " " + tuple.Item2 + " " + tuple.Item3;

            //Using Value Tuple
            //(string name, int age, int height) tuple = ("subroto", 27, 3);
            // var a = tuple.name + " " + tuple.age + " " + tuple.height;
            
            //We can also assign member names on the right side with values
            var tuple = (name:"subroto", age:27, height:3);
            var a = tuple.name + " " + tuple.age + " " + tuple.height;
           
            var t1=("s",4,7);
            var b = t1.Item1 + " " + t1.Item2 + " " + t1.Item3;

            Console.WriteLine(b);
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
