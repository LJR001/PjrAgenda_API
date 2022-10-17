using System;
using System.Collections.Generic;

namespace PjrAgenda_API.Models
{
    public class Person
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday  { get; set; }
        public string Phone { get; set; }

        public virtual List<Address> Address { get; set; }
    }
}
