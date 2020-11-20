using System;
using System.IO;

namespace _6Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("............input..........");
            string filePath = @"E:\DST\text.txt";
            string[] array = new string[4];
            for (int i = 0; i < array.Length; i++)
            { 
                array[i] = Console.ReadLine();
            } 
            File.WriteAllLines(filePath, array);

            string[] readFileList = File.ReadAllLines(filePath);
            Console.WriteLine("..................Output.......................");
            for (int i = 0; i < readFileList.Length; i++)
            {
                Console.WriteLine(readFileList[i]);
            }
            Console.ReadLine();
        }
    }
}
