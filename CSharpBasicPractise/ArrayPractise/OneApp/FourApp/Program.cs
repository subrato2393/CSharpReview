using System;

namespace FourApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number of array");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int[] array2 = new int[n];
            Console.WriteLine($"Enter {n} Number");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                array2[i] = array[i];
            }
            
            Console.Write("Elements from first array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" "+array[i]);
            }

            Console.Write("\n Elements from second array : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array2[i]);
            }

            Console.ReadLine();
        }
    }
}
