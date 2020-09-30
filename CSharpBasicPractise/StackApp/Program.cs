using System;
using System.Collections;
using System.Collections.Generic;

namespace StackApp
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
            Stack<Customer> customers = new Stack<Customer>();
            customers.Push(aCustomer);
            customers.Push(bCustomer);
            customers.Push(cCustomer);
           
            foreach (var item in customers)
            {
                Console.WriteLine(item.Name+" "+item.Age);
            }
            //var pop=customers.Pop();
            //Console.WriteLine(pop.Name);
            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}
            Console.WriteLine("..................");
            var peek= customers.Peek();
            Console.WriteLine(peek.Name + " " + peek.Age);
            foreach (var item in customers)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            var count=  customers.Count;
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
