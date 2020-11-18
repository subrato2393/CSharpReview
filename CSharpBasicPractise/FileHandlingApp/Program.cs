using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write to a text file

            //Input value
            string item1 = "name:subroto,Email:s@gmail.com";
            string item2 = "phone:01283838,address:dhaka";
            
            //file path
            string filePath = @"E:\DST\text.txt";
           
            //Add value in string
            List<string> list = new List<string>();
            list.Add(item1);
            list.Add(item2);

            //Write file
            File.WriteAllLines(filePath, list);
            Console.WriteLine("......File Write Successfully.......\n");

            //Read From a file
            var listOfValue= File.ReadAllLines(filePath).ToList();

            //Add another  One item To that file
            listOfValue.Add("Added new item");
           
            //Print console that file information
            foreach (var item in listOfValue)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
