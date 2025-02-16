using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Instructor : BaseEntity
    {

        [Required]
        [StringLength(50)]
        public string Ins_Name { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public virtual Department Department { get; set; }

    }
}
