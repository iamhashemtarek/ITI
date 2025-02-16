using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Department : BaseEntity
    {

        [Required]
        [StringLength(50)]
        public string Dept_Name { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
