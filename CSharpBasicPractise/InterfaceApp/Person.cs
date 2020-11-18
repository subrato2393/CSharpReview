using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp
{
    public class Person : IPerson
    {
        public string FirstName { get; set;}
        public string MiddleName { get; set; }
        public string LastName { get; set;}
        protected string PhoneNo { get; set; }
        public Person()
        {

        }
    }
}
