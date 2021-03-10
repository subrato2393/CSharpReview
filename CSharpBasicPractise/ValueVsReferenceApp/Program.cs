using System;

namespace ValueVsReferenceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            b = 12;
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);

            Student aStudent = new Student();
            aStudent.Id = 1;

            Student bStudent = aStudent;
            bStudent.Id = 10;
                                                            
            Console.WriteLine(aStudent.Id);
            Console.WriteLine(bStudent.Id);

            Console.ReadLine();
        }
    }
}
