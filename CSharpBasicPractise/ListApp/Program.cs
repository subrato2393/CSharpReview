using System;
using System.Collections.Generic;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var aCustomer = new Customer()
            {
                Id = 1,
                Name = "subroto",
                Age = "27"
            };
            var bCustomer = new Customer()
            {
                Id = 2,
                Name = "subro",
                Age = "22"
            };
            var cCustomer = new Customer()
            {
                Id = 3,
                Name = "suvo",
                Age = "30"
            };
            List<Customer> customers = new List<Customer>();
            customers.Add(aCustomer);
            customers.Add(cCustomer);
            customers.Add(bCustomer);

            var x =customers[1];
            Console.WriteLine("........................"+x.Name);
            foreach (var item in customers)
            {
                Console.WriteLine(item.Name+" "+item.Age);
            }
            Console.WriteLine("Remove 1 customer");
            customers.Remove(bCustomer);
            Console.WriteLine("Show All customer ");
            foreach (var item in customers)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            customers.Insert(2, bCustomer);
            Console.WriteLine("Show All customer ");
            foreach (var item in customers)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            customers.RemoveAt(2);
            Console.WriteLine("Show All customer ");
            foreach (var item in customers)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
           var name= customers.Find(x => x.Name == "subro");
            Console.WriteLine("Subro "+name);
            Console.ReadLine();
        }
    }
}
