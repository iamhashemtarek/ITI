using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Instructor name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Instructor name must be between 3 and 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Salary is required.")]
        [Range(1000, 100000, ErrorMessage = "Salary must be between 1,000 and 100,000.")]
        public int Salary { get; set; }

        [StringLength(255, ErrorMessage = "Address cannot exceed 255 characters.")]
        public string Address { get; set; }

        //[Url(ErrorMessage = "Invalid image URL format.")]
        public string Image { get; set; }

        public int? DeptId { get; set; }
        public virtual Department Department { get; set; }

        [Required(ErrorMessage = "Course ID is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Course ID must be a positive number.")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
