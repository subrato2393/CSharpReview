using System;
using System.IO;

namespace _9App
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\DST\subr.text";
            string destinationFile = @"E:\DST\destination.text";
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
            File.Move(filePath, destinationFile);
            Console.WriteLine("Write All file Successfully");

            Console.WriteLine("...................");
            Console.WriteLine("Read all files ");

            string[] linearr = File.ReadAllLines(destinationFile);
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
