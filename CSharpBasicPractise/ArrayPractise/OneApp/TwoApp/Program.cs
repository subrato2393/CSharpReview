using System;

namespace TwoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number nth");
          
            int n =Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            
            Console.WriteLine($"Enter {n} Number");

            for (int i = 0;  i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            Console.Write(" Reverse Elements are : ");
           
            for (int i = n-1; i >= 0; i--)
            {
                int temp = array[i];
                Console.Write(" " + temp);
            }

            Console.ReadLine();
        }
    }
}
