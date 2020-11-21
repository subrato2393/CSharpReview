using System;
using System.IO;

namespace _9App
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\DST\subr.text";
            // string destinationFile = @"E:\DST\destination.text";
            using (FileStream fileStream = File.Create(filePath))
            {
                Console.WriteLine("File created successfully");
            }
            int n = 4;
            string[] contents = new string[n];

            for (int i = 0; i < contents.Length; i++)
            {
                contents[i] = Console.ReadLine();
            }
            File.WriteAllLines(filePath, contents);

            using (StreamWriter streamWriter = File.AppendText(filePath))
            {
                //streamWriter.Write("Added some Text");
            }
            // File.Move(filePath, destinationFile);
            Console.WriteLine("Write All file Successfully");

            Console.WriteLine("...................");
            Console.WriteLine("Read all files ");

            int count = 0;
            string[] linearr = File.ReadAllLines(filePath);
            Console.WriteLine("Please enter The line number");
            for (int i = 0; i < linearr.Length; i++)
            {
                count++;
                    if (!linearr[i].Contains("fox"))
                    {
                        Console.WriteLine(linearr[i]);
                    }
                    else
                    {
                        Console.WriteLine(linearr[i]);
                    }
                
            }
            Console.WriteLine($"total Line count is {count}");
            Console.ReadLine();
        }
    }
}
