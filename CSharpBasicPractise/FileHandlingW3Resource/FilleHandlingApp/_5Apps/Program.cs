using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5Apps
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
            string[] contents = new string[3];

            for (int i = 0; i < contents.Length; i++)
            {
                contents[i] = Console.ReadLine();
            }
            File.WriteAllLines(filePath, contents);
            Console.WriteLine("Write All file Successfully");

            Console.WriteLine("...................");
            Console.WriteLine("Read all files ");

            List<string> lineList = File.ReadAllLines(filePath).ToList();
            foreach (var item in lineList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
