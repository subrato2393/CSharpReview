using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _6App
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\DST\subr.text";
            using (FileStream fileStream = File.Create(filePath))
            {
                Console.WriteLine("File created successfully");
            }
            string[] contents = new string[2];

            for (int i = 0; i < contents.Length; i++)
            {
                contents[i] = Console.ReadLine();
            }
            File.WriteAllLines(filePath, contents);
           

            Console.WriteLine("Write All file Successfully");

            Console.WriteLine("...................");
            Console.WriteLine("Read all files ");

            string[] linearr = File.ReadAllLines(filePath);
            for (int i = 0; i < linearr.Length; i++)
            {
                if (!linearr[i].Contains("fox"))
                {
                    Console.WriteLine(linearr[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
