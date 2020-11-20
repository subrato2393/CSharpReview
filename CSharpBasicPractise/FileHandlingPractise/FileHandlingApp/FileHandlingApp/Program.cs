using System;
using System.IO;

namespace FileHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\DST\subroto.txt"; 

            //create file command
           // FileStream fileStream = File.Create(filePath);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            //remove file from the disk
            // File.Delete(filePath);
            // Console.WriteLine("A file Delete Successfully");
            string blankFile = @"E:\DST\blanks.txt";
            FileStream fileStream = File.Create(blankFile);
            Console.WriteLine("Blank file created successfully");
            Console.ReadLine();
        }
    }
}
