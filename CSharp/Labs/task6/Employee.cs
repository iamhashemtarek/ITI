using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Employee: IComparable<Employee>
    {
        int id;
        int salary;
        Gender gender;
        HiringDate hiringDate;
        Privilage empPrivilage;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Salary
        {
            get { return salary; }
            set
            {
                if (salary < 0)
                    throw new ArgumentOutOfRangeException();
                else
                    salary = value;
            }
        }
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public HiringDate HiringDate
        {
            get { return hiringDate; }
            set
            {
                //hiringDate.Day = value.Day;
                //hiringDate.Month = value.Month;
                //hiringDate.Year = value.Year;
                hiringDate = value;
            }
        }
        public Privilage EmpPrivilage { get; set; }
        public Employee(int id, int salary, Gender gender, HiringDate hiringDate, Privilage privilage)
        {
            Id = id;
            Salary = salary;
            Gender = gender;
            HiringDate = hiringDate;
            EmpPrivilage = privilage;
        }
        public override string ToString()
        {
            return $"id: {id}, salary: {salary.ToString("C")}, gender: {gender}, hiring data: {hiringDate.ToString()}, privilage: {EmpPrivilage}";
        }
        public long getHiringDateInSec()
        {
            DateTime date = new DateTime(hiringDate.Year, hiringDate.Month, hiringDate.Day);
            long hiringDateInSec = new DateTimeOffset(date).ToUnixTimeSeconds();
            return hiringDateInSec;
        }

        public int CompareTo(Employee? other)
        {
            return this.getHiringDateInSec().CompareTo(other.getHiringDateInSec());
        }
    }
}

