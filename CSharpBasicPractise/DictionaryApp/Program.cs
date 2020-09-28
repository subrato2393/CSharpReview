using System;
using System.Collections.Generic;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionaries = new Dictionary<int, string>();
            dictionaries.Add(1, "Mobile");
            dictionaries.Add(2, "Monitor");
            dictionaries.Add(3, "Headphone");
            dictionaries.Add(4, "Keyboard");
            foreach (var item in dictionaries)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }
            try
            {
                //Same key can't add
                dictionaries.Add(3, "Mouse");
                Console.WriteLine(dictionaries[3]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                //different key but same key value
                dictionaries.Add(5, "Mouse");
                Console.WriteLine(dictionaries[3]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //If the key not in the dictionary

            dictionaries[6] = "Samsung";
            try
            {
                Console.WriteLine(dictionaries[6]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if(dictionaries.ContainsKey(1))
            {
                dictionaries.Remove(1);
                Console.WriteLine("Remove 1 key from dictionary");
                foreach (var item in dictionaries)
                {
                    Console.WriteLine(item.Key+"  "+item.Value);
                }
            }
            Console.WriteLine("Add 1 item to the dictionary");
            dictionaries.Add(1, "Mobiles");
            foreach (var item in dictionaries)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
            //
            //dictionaries.Clear();
            //Console.WriteLine("After clean dictionary");
            //foreach (var item in dictionaries)
            //{
            //    Console.WriteLine(item.Value);
            //}
            if(dictionaries.ContainsValue("Mobiles"))
            {
                Console.WriteLine("This is present");
            }
            Console.WriteLine("Remove Mobiles");
            dictionaries.Remove(1);
            if(dictionaries.ContainsValue("Mobiles"))
            {
                Console.WriteLine("Contains mobile");
            }
            else
            {
                Console.WriteLine("Not contain mobile");
            }
            int count=dictionaries.Count;
            Console.WriteLine("Count "+count);
            
            Console.WriteLine("All items");
            foreach (var item in dictionaries)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

            Console.WriteLine("After using try get value method"); 
            string name = "subroto";
            if(dictionaries.TryGetValue(6, out name))
            {
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.WriteLine(dictionaries[6]);
            //foreach (var item in dictionaries)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}

            Console.ReadLine();
        }
    }
}
