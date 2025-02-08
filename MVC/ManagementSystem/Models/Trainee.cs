using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Models
{
    public class Trainee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Trainee name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Trainee name must be between 3 and 100 characters.")]
        public string Name { get; set; }

        [StringLength(255, ErrorMessage = "Address cannot exceed 255 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Grade is required.")]
        [StringLength(10, ErrorMessage = "Grade must be a maximum of 10 characters.")]
        public string Grade { get; set; }

        //[Url(ErrorMessage = "Invalid image URL format.")]
        public string Image { get; set; }

        public int? DeptId { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<CourseResult> CourseResults { get; set; } = new List<CourseResult>();
    }
}
