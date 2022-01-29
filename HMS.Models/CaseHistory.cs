using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Models
{
    public class CaseHistory
    {
        public int CaseId { get; set; }
        public string Disease { get; set; }
        public DateTime AdmittedOn { get; set; }
        public string Symptoms { get; set; }
        public string PriorTreatments { get; set; }
        public string ReferredBy { get; set; }
        public Doctor TreatedBy { get; set; }
        public DateTime DischargedOn { get; set; }
        public string DischargeSummary { get; set; }
    }
}
