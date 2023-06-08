using System;
using System.ComponentModel.DataAnnotations;

namespace employeTracker.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public int Age { get; set; }

        public string Department { get; set; }

        public string PhoneNumber { get; set; }

        public string BirthDate { get; set; }
    }
}
