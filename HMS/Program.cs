using System;

public class Hospital
{
    public string HospitalName
    { get; set; }
    public string RegistrationNumber
    { get; set; }
    public string Address
    { get; set; }
    public Hospital(string regNo, string name, string address)
    {
        this.HospitalName = name;
        this.RegistrationNumber = regNo;
        this.Address = address;
    }
}

interface IPerson
{
    public void Add();
    public void Delete();
    public void Edit();
    public void Search();
}

public class CaseHistory
{
    public void Disease()
    { throw new NotImplementedException(); }
    public void Symptoms()
    { throw new NotImplementedException(); }
    public void PriorTreatments()
    { throw new NotImplementedException(); }
    public void ReferredAnyTreatment()
    { throw new NotImplementedException(); }
    public void PriorSurgeries()
    { throw new NotImplementedException(); }
}
interface ITreatment
{
    public void Treatment();
}
interface IReferDoctor
{
    public void ReferDoctor();
}
public class Patient : CaseHistory, IPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string BloodGroup { get; set; }
    public string Gender { get; set; }
    public virtual void Add()
    {
        this.Id = 123;
        this.Name = "A";
        this.Address = "xxxxx";
        this.BloodGroup = "B + ve";
        this.Gender = "Male";
    }
    public void Delete()
    { }
    public void Edit()
    { }
    public void Search()
    { }
    public string AssignDoctor(string doctorId)
    { return doctorId; }

    public int AssignRoom(int roomNumber)
    { return roomNumber; }

    public decimal Deposit()
    { return 10000; }

    public decimal BillAmount()
    { return 7500; }

    public decimal ReturnAmount()
    { return 2500; }

}
interface IShiftDetails
{
    public void CalculateHoursofWork();

}
interface ISalary
{
    public void CalculateSalary();
}

public class TraineeDoctor : CaseHistory, IPerson, ITreatment, IReferDoctor, IShiftDetails, ISalary
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string BloodGroup { get; set; }
    public string Gender { get; set; }
    public virtual void Add()
    {
        this.Id = "TRAINEE123";
        this.Name = "A";
        this.Address = "xxxxx";
        this.BloodGroup = "B + ve";
        this.Gender = "Male";
    }
    public virtual void Delete()
    { throw new NotImplementedException(); }
    public virtual void Edit()
    { throw new NotImplementedException(); }
    public virtual void Search()
    { throw new NotImplementedException(); }
    public virtual void Treatment()
    { throw new NotImplementedException(); }
    public virtual void ReferDoctor()
    { throw new NotImplementedException(); }
    public virtual void CalculateHoursofWork()
    { throw new NotImplementedException(); }
    public virtual void CalculateSalary()
    { throw new NotImplementedException(); }
}
public class Doctors : TraineeDoctor
{

    public override void Add()
    {
        this.Id = "TRAINEE123";
        this.Name = "A";
        this.Address = "xxxxx";
        this.BloodGroup = "B + ve";
        this.Gender = "Male";
    }
    public override void Delete()
    { }
    public override void Edit()
    { }
    public override void Search()
    { }
    public override void Treatment()
    { throw new NotImplementedException(); }
    public override void ReferDoctor()
    { throw new NotImplementedException(); }
    public override void CalculateHoursofWork()
    { }
    public override void CalculateSalary()
    { }

    public class Specialists : Doctors
    {
        public void Pediatrician()
        { }
        public void Gyneogolists()
        { }
        public void Dentist()
        { }
        public void ENT()
        { }
        public void Psychiatrist()
        { }
        public void Cardiologist()
        { }


    }
    sealed class Surgeons : CaseHistory, IPerson, ITreatment, IShiftDetails, ISalary
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        public void Add()
        {
            this.Id = "TRAINEE123";
            this.Name = "A";
            this.Address = "xxxxx";
            this.BloodGroup = "B + ve";
            this.Gender = "Male";
        }
        public void Delete()
        { }
        public void Edit()
        { }
        public void Search()
        { }
        public void Treatment()
        { throw new NotImplementedException(); }
        public void CalculateHoursofWork()
        { throw new NotImplementedException(); }
        public void CalculateSalary()
        { throw new NotImplementedException(); }
        public void PerformSurgery()
        { throw new NotImplementedException(); }
    }

    public class LabTechnicians
    { }

    public class INursingDepartment
    {
        public void HeadNurse()
        { }
        public void StaffNurse()
        { }
        public void TraineeNurse()
        { }
    }
    public class Pharmacy
    {
    }
    public class Administration
    {
        public void Receptionist()
        { }
        public void Administrator()
        { }

        public void Assistant()
        { }
        public void Manager()
        { }
        public void DataEntryClerk()
        { }
        public void Cousellors()
        { }
    }

    public class Accounts
    {
        public void JuniorAccountant()
        { throw new NotImplementedException(); }
        public void SeniorAccountant()
        { throw new NotImplementedException(); }
        public void Auditor()
        { throw new NotImplementedException(); }
    }

    public class Ambulance
    {
        public void Drivers()
        { }
        public void Equipments()
        { }
    }

    public class HouseKeeping
    {
        public void Sweepers()
        { }

    }
    public class Security
    {
        public void SecurityHead()
        { }

        public void SecurityGuards()
        { }

    }



    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
