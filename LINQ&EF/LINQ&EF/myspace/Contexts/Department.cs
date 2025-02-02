using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myspace.Contexts
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }

        [InverseProperty("Department")]
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
