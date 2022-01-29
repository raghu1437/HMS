using HMS.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Models
{
    public class Patient:Person
    {
        public PatientType PatientType { get; set; }
        public List<CaseHistory> CaseHistories { get; set; }
    }
}
