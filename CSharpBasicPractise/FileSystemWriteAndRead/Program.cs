using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileSystemWriteAndRead
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write Text in A file
            string filePath = @"E:\DST\test.txt";
            List<Person> people = new List<Person>();
            people.Add(new Person() { FirstName = "subroto", LastName = "ghosh", Email = "a@mail.com" });
            people.Add(new Person() { FirstName = "abd", LastName = "ghosh", Email = "sho@mail.com" });
            people.Add(new Person() { FirstName = "jon", LastName = "ghosh", Email = "j@mail.com" });

            List<string> strList = new List<string>();
            foreach (var item in people)
            {
                strList.Add(item.FirstName + "," + item.LastName + "," + item.Email);
            }
            File.WriteAllLines(filePath, strList);

            //Read text from a file
            var lines = File.ReadAllLines(filePath).ToList();
            List<Person> personList = new List<Person>();

            foreach (var item in lines)
            {
                Person person = new Person();
              
                var newItem = item.Split(",");
                person.FirstName = newItem[0];
                person.LastName = newItem[1];
                person.Email = newItem[2];
                personList.Add(person);
            }
            foreach (var item in personList)
            {
                Console.WriteLine(item.FirstName+","+item.LastName+","+item.Email);
            }
            Console.WriteLine();
        }

    }
}
