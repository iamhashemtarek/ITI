using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8;

internal class Club
{
    private EmployeesList employees;
    public Club() { employees = new EmployeesList(); }
    public Club(EmployeesList employees) { this.employees = employees; }
    public void OnAddEmployee(object sender, EventArgs e)
    {
        if(sender is Employee employee)
        {
            this.employees.Add(employee);
        }
    }
    public void Subscribe(Employee employee)
    {
        employee.AddEmployee += OnAddEmployee;
        
        OnAddEmployee(employee, EventArgs.Empty);
    }

    public override string ToString()
    {
        return employees.ToString();
    }
}
