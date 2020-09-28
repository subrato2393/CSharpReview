using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type customerType = typeof(Customer);
            Type customerType = Type.GetType("Reflection.Customer");

            Console.WriteLine(".......Type Name");
            string name = customerType.Name;
            Console.WriteLine(name);

            Console.WriteLine("..........All Property And Property Type");
            PropertyInfo[] properties = customerType.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.PropertyType + "  " + property.Name);
            }

            string nameSpace = customerType.Namespace;
            Console.WriteLine("..........nameSpace" + nameSpace);

            Console.WriteLine(".........Method Info");
            MethodInfo[] methods = customerType.GetMethods();
            foreach (var method in methods)
            {
                ParameterInfo[] parameters = method.GetParameters();
                 foreach (var parameter in parameters)
                {
                    Console.WriteLine("Parameters "+parameter.Name+method.Name);
                }
                Console.WriteLine(method.Name + " " + method.ReturnType + " " + method.ReturnParameter);
            }

            ConstructorInfo[] constructors = customerType.GetConstructors();
            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor.Name + " " + constructor.ToString());
            }
            Console.WriteLine("Get fields ");
           FieldInfo[] fields= customerType.GetFields();
            foreach (var field in fields)
            {
                Console.WriteLine(field.Name+" "+field.FieldType.FullName);
            }
            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Enum Genders { get; set; }

        public string email = "s@gmail.com";

        //public enum Gender
        //{
        //    Male,
        //    Female
        //}
        public Customer()
        {

        }
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            //this.Genders = gender;
        }
        public void GetFullInfo(int id)
        {
            string fullName = Id + "  " + Name;
        }
        public string GetName()
        {
            return Name;
        }

    }
}
