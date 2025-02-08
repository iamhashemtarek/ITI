using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Models
{
    public class Employee : ModelBase
    {
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage = "Max length of name is 50 char")]
        [MinLength(5, ErrorMessage = "Min length of name is 5 char")]
        public string Name {  get; set; }


        [Range(22, 30)]
        public int Age { get; set; }

        public string Address { get; set; }


        [DataType(DataType.Currency)]
        public decimal Salary {  get; set; }

        public bool IsActive {  get; set; }


        [EmailAddress]
        public string Email { get; set; }


        [Phone]
        public string Phone { get; set; }

        public DateTime HireDate {  get; set; } 

        public bool IsDeleted { get; set; } 

        public DateTime CreationDate {  get; set; }
    }
}
