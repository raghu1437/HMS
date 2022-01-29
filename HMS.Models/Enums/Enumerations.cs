using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Models.Enums
{
    public enum HSMRole
    { 
      Doctor =1,
      Patient = 2,
      Nurse =3,
      Technicians =4,
      Admin = 5,
      Accountant =6,
      HouseKeeping =7,
      AmbulanceDrivers = 8,
      Pharmacist =9
    }

    public enum PatientType
    { 
      IN=1,
      OUT=2
    }
}
