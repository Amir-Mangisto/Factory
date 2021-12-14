using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory.Models
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public int dateOfBirth;
        public int phone;

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, int dateOfBirth, int phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.phone = phone;
        }



    }
}