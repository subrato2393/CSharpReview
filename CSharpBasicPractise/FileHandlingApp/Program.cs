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
            string item2 = "name:subro,Email:sh@gmail.com";
            string item3 = "name:suvo,Email:sv@gmail.com";

            List<Person> persons = new List<Person>()
            {
                new Person(){FirstName="subroto",LastName="ghosh",Email="s@gmail.com"},
                new Person(){FirstName="subro",LastName="ghosh",Email="k@gmail.com"},
                new Person(){FirstName="suvo",LastName="ghosh",Email="y@gmail.com"},
            };
            //file path
            string filePath = @"E:\DST\text.txt";
            List<string> strList = new List<string>();
            foreach (var item in persons)
            {
                strList.Add("First Name :"+item.FirstName+" "+"Last Name : "+item.LastName+" "+"Email :"+item.Email);
            }
            //foreach (var item in strList)
            //{
                
            //}

            //Add value in string
            //List<string> list = new List<string>();
            //list.Add(item1);
            //list.Add(item2);
            //list.Add(item3);

            //Write file
            File.WriteAllLines(filePath, strList);
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
