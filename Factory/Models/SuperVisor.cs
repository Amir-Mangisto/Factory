using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory.Models
{
    public class SuperVisor
    {
        public string firstName;
        public string lastName;
        public int dateOfBirth;
        public int years;

        public SuperVisor()
        {
        }

        public SuperVisor(string firstName, string lastName, int dateOfBirth, int years)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.years = years;
        }
    }

}