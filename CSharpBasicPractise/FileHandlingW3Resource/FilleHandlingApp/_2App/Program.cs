using System;
using System.IO;

namespace _2App
{
    class Program
    { 
        static void Main(string[] args)
        {
            string filePath = @"E:\DST\subroto.text";
            //Console.WriteLine("File created successfully.....");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("File Delete successfully");
            }
            else
            {
                Console.WriteLine("File not exists");
            }

            Console.ReadLine();
        }
    }
}
