using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Department name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Department name must be between 3 and 100 characters.")]
        public string Name { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
        public virtual ICollection<Trainee> Trainees { get; set; } = new List<Trainee>();
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

        [Range(1, int.MaxValue, ErrorMessage = "Manager ID must be a positive number.")]
        public int? ManagerId { get; set; }

        public virtual Instructor Manager { get; set; }
    }
}
