using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Models
{
    public class Person
    {
        public int PersonID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public string City { get; set; }

         
    }
}