using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory.Models
{
    public class Manager
    {
        public string firstName;
        public string lastName;
        public string department;

        public Manager()
        {
        }

        public Manager(string firstName, string lastName, string department)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.department = department;
        }
    }
}