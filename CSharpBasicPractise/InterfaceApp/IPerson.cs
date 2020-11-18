using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp
{
    public interface IPerson
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; } 
    }
}
