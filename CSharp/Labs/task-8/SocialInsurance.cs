using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    internal class SocialInsurance
    {
        private EmployeesList employees;
        public SocialInsurance() { employees = new EmployeesList(); }
        public SocialInsurance(EmployeesList employees) { this.employees = employees; }
        public void OnAddEmployee(object sender, EventArgs e)
        {
            if (sender is Employee employee)
            {
                this.employees.Add(employee);
            }
        }
        public void OnRemoveEmployee(object sender, EventArgs e)
        {
            if (sender is Employee employee)
            {
                this.employees.Remove(employee);
            }
        }
        public void Subscribe(Employee employee)
        {
            employee.AddEmployee += OnAddEmployee;
            employee.RemoveEmployee += OnRemoveEmployee;

            if(employee.Age < 60)
                OnAddEmployee(employee, EventArgs.Empty);
            else
                OnRemoveEmployee(employee, EventArgs.Empty);

        }

        public void Unsubscribe(Employee employee)
        {
            employee.AddEmployee -= OnAddEmployee;
            employee.RemoveEmployee -= OnRemoveEmployee;
        }
        public override string ToString()
        {
            return employees.ToString();
        }
    }
}
