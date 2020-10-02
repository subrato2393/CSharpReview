using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HashSetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hashValue = new HashSet<int>();

            hashValue.Add(3);
            hashValue.Add(6);
            hashValue.Add(2);
            hashValue.Add(1);
            hashValue.Add(10);

            HashSet<int> secondhashValue = new HashSet<int>();
            secondhashValue.Add(13);
            secondhashValue.Add(16);
            secondhashValue.Add(18);
            secondhashValue.Add(25);
            secondhashValue.Add(20);
            hashValue.UnionWith(secondhashValue);
            //HashSet<int> numbers = new HashSet<int>(hashValue);
            //numbers.UnionWith(secondhashValue);
            foreach (var item in hashValue)
            {
                Console.WriteLine(item);
            }

            //foreach (var item in hashValue)
            //{
            //    Console.WriteLine(item);
            //}
            //if (hashValue.Contains(7))
            //{
            //    Console.WriteLine("duplicated");
            //}
            //else
            //{
            //    hashValue.Add(7);
            //}

            StringBuilder result = new StringBuilder("(" + "ffff" + ")");
            Console.ReadLine();
        }
    }
}
