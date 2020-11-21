using System;
using System.IO;

namespace _3App
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\DST\text.txt";
            //Console.WriteLine("File created successfully.....");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("File delete successfully");
            }
                using (FileStream fileStream = File.Create(filePath))
                {
                    Console.WriteLine("File created successfully");
                }
            Console.ReadLine();
        }
    }
}
