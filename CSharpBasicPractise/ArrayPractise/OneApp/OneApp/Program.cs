using System;

namespace OneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int []array = new int[10];
            Console.WriteLine("Enter 10 Number");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elements are : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" "+array[i]);
            }

            Console.ReadLine();
        }
    }
}
