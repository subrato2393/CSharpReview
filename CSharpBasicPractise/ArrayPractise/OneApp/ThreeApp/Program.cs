using System;

namespace ThreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number nth");

            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int temp = 0;
            Console.WriteLine($"Enter {n} Number");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                temp += array[i];
            }

            Console.Write(" Sum of all element is   : "+temp);

           

            Console.ReadLine();
        }
    }
}
