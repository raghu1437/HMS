using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Models
{
    public class Hospital
    {
        public string HospitalName { get; set; }
        public string RegistrationNumber  { get; set; }
        public string Address { get; set; }
        public Hospital(string regNo, string name, string address)
        {
            this.HospitalName = name;
            this.RegistrationNumber = regNo;
            this.Address = address;
        }
    }
}
