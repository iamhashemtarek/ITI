using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    internal class Employee
    {
        int age;
        private int id = 0;
        public event EventHandler AddEmployee;
        public event EventHandler RemoveEmployee;
        //public Club club;
        public int Id 
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name { get; set; }
        public int Age 
        {
            get { return this.age; }   
            set
            {
                this.age = value;
                addEmployee();
                //if (this.age >= 60) 
                //{
                //    RemoveEmployee?.Invoke(this, EventArgs.Empty); //firing add event
                //}else
                //{
                //    AddEmployee?.Invoke(this, EventArgs.Empty);
                //}

            }
        }
        //public Employee() { }
        public Employee(string name, int age) 
        {
            this.Id = ++id;  
            this.Name = name;   
            this.Age = age; 
        }

        public void addEmployee()
        {
            if (this.age >= 60)
            {
                RemoveEmployee?.Invoke(this, EventArgs.Empty); //firing add event
            }
            else
            {
                AddEmployee?.Invoke(this, EventArgs.Empty);
            }
        }

        public override string ToString()
        {
            return $"{Id}- {Name}- {Age}";
        }

    }
}
