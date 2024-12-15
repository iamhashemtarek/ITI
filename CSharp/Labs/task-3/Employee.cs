using System;

namespace task_3
{
    struct HiringDate
    {
        int day;
        int month;
        int year;

        public int Day
        {
            get { return day; }
            set
            {
                if(value <0 ||  value > 31)
                    throw new ArgumentOutOfRangeException();
                else 
                    day = value;
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value < 0 || value > 12)
                    throw new ArgumentOutOfRangeException();
                else
                    month = value;
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0 || value > 2024)
                    throw new ArgumentOutOfRangeException();
                else
                    year = value;
            }
        }

        public HiringDate(int day, int month, int year) 
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{day}-{month}-{year}";
        }
    }

    enum Gender
    {
        male, 
        female,
    }
    
    internal class Employee
    {
        int id;
        int salary;
        Gender gender;
        HiringDate hiringDate;

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
        public Employee(int id, int salary, Gender gender, HiringDate hiringDate)
        {   
            Id = id;
            Salary = salary;
            Gender = gender;
            HiringDate = hiringDate;
        }
        public override string ToString()
        {
            return $"id: {id}, salary: {salary}, gender: {gender}, hiring data: {hiringDate.ToString()}";
        }
        public long getHiringDateInSec()
        {
            DateTime date = new DateTime(hiringDate.Year, hiringDate.Month, hiringDate.Day);
            long hiringDateInSec = new DateTimeOffset(date).ToUnixTimeSeconds();
            return hiringDateInSec;
        }

    }


}
