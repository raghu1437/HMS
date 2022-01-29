using HMS.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber {get;set;}
        public string Address { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        public HSMRole Role { get; set; }
    }
}
