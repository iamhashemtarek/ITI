using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    internal class EmployeesList: List<Employee>
    {
        public override string ToString()
        {
            StringBuilder employee = new StringBuilder();
            foreach (Employee e in this) 
            {
                employee.AppendLine(e.ToString());
            }
            return employee.ToString(); 
        }
    }
}
