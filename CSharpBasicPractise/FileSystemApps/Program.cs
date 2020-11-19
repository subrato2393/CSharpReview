using FileSystemReadAndWrite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileSystemApps
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Read from the file
            string filePath = @"E:\DST\text.txt";
            var files= File.ReadAllLines(filePath).ToList();
            List<Person> people = new List<Person>(); 

            foreach (var item in files)
            {
                var newItem=item.Split(",");

                Person aPerson = new Person();
                aPerson.FirstName = newItem[0].ToString();
                aPerson.LastName = newItem[1].ToString();
                aPerson.Email = newItem[2].ToString();
                people.Add(aPerson);
            }
            foreach (var item in people)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.Email}");
            }

            //foreach (var item in files)
            //{
            //    Console.WriteLine(item);
            //}


            //Write to a file
            // files.Add("jon,de,j@gmail.com");
            people.Add(new Person() { FirstName = "dev", LastName = "skill", Email = "dev@gmail.com" });
            var strList = new List<string>();
            foreach (var item in people)
            {
                strList.Add($"{item.FirstName}, {item.LastName}, {item.Email}");
            }

            File.WriteAllLines(filePath, strList);
            Console.WriteLine("Write successfully");

            Console.ReadLine();
        }
    }
}
