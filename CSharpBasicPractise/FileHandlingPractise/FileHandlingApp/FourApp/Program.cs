using System;
using System.IO;

namespace FourApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\DST\skfile.txt";

            //Create file and write some text in file
            StreamWriter fileStream = File.CreateText(filePath);
            fileStream.WriteLine("Add first content to file");
            fileStream.WriteLine("Hello and  welcome");
            fileStream.WriteLine("This is the skfile.txt");
            fileStream.Flush();
            fileStream.Close();
            Console.WriteLine("File write successfully");

            //Read text in file
            StreamReader streamReader = File.OpenText(filePath);
            string s = "";
            
            while ((s=streamReader.ReadLine()) !=null)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
