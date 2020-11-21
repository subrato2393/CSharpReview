using System;
using System.Collections.Generic;
using System.IO;

namespace _5App
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\DST\subr.text";
            using (FileStream fileStream=File.Create(filePath))
            {
                Console.WriteLine("File created successfully");
            }
            string[] contents = new string[3];

            for (int i = 0; i < contents.Length; i++)
            {
                contents[i] = Console.ReadLine();
            }
            File.WriteAllLines(filePath, contents);
            Console.WriteLine("Write All file Successfully");

            Console.ReadLine();
        }
    }
}
