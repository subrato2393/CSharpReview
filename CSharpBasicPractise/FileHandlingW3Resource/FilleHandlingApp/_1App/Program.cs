using System;
using System.IO;

namespace _1App
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\DST\subroto.txt";
            File.Create(filePath);
            Console.WriteLine("File created successfully");
            Console.ReadLine();
        }
    }
}
