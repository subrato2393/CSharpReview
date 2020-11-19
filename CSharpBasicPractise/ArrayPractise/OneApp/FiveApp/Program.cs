using System;

namespace FiveApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int[] array2 = new int[n];
            Console.WriteLine($"Enter {n} Number");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                array2[i] = array[i];
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array2[j])
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine("Number of Duplicate elements " + sum);

            Console.ReadLine();
        }
    }
}
