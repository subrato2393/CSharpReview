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
            Console.WriteLine("Please enter number of line you input");
          
            int n = Convert.ToInt32(Console.ReadLine());
            
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
            int input = Convert.ToInt32(Console.ReadLine());
            int line = n - input;
            for (int i = line; i < linearr.Length; i++)
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
