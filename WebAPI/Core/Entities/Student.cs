using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Student : BaseEntity
    {

        [Required]
        [StringLength(50)]
        public string St_Name { get; set; }

        [Required]
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public virtual Department Department { get; set; }

    }
}
