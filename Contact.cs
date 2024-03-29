﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MaintainingAddressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string EmailAddress { get; set; }
        public int PostalCode { get; set; }
        public long MobileNumber { get; set; }
    }
}