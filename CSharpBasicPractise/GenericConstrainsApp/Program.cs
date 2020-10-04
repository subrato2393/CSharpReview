using System;
using System.Text;

namespace GenericConstrainsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //when T:struct for all value type
            //NodeList<int> intList = new NodeList<int>();
            //NodeList<double> doubleList = new NodeList<double>();
            //NodeList<char> charList = new NodeList<char>();

            //if provide string then getting compiler error
            //because string is a reference type
            // NodeList<string> stringList = new NodeList<string>();

            //When T:class for all reference type
            //NodeList<string> intList = new NodeList<string>();
            //NodeList<Employee> employeeList = new NodeList<Employee>();

            //When T:new() for which type has one parameter less constructor
            //NodeList<Employee> nodeList = new NodeList<Employee>();

            //compiler error because customer contructor has parameter
            // NodeList<Customer> customerList = new NodeList<Customer>();

            //When T:<interface> take those class which implemet that interface
            //  NodeList<Employee> employeeList = new NodeList<Employee>();
            ////compiler error because customer do not implement IEmployee Interface
            // NodeList<Customer> customerList = new NodeList<Customer>();


            //When T:<baseclass>  take those class which derived form that base class
            //compiler because customer not inherit form that base class
            //NodeList<Customer> customerList = new NodeList<Customer>();
            //    NodeList<Employee> employeeList = new NodeList<Employee>();

            //When NodeList<T,U> where T : U if T inherit from U base class/abstract class/interface 
            //NodeList<Employee, BaseClass> nodeList = new NodeList<Employee, BaseClass>();
            //NodeList<Employee, IEmployee> nodeList1 = new NodeList<Employee, IEmployee>();
            //////Compiler error because customer(T) not inherit inherit from BaseClass(U)
            //NodeList<Customer, BaseClass> node = new NodeList<Customer, BaseClass>();
        }
    }
}
