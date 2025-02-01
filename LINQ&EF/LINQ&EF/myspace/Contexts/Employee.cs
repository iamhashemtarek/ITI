using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myspace.Contexts
{
    internal class Employee
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required][Column(TypeName = "varchar")]
        [StringLength(50, MinimumLength =10)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public double Salary {  get; set; } 

        [Range(22, 60)]
        public int Age { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{Id}-{Name}";
        }
    }
}
