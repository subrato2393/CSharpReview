using System;
using System.IO;

namespace _8Apps
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

            using (StreamWriter streamWriter = File.AppendText(filePath))
            {
                streamWriter.Write("Added some Text");
            }
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
                else
                {
                    Console.WriteLine(linearr[i]);
                }
            }

            Console.ReadLine();
        }
    }
}