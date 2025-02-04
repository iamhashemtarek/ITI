using ManagementSystem.Models;

namespace ManagementSystem.ViewModel
{
    public class InstructorWithDeptsAndWithCourses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public int? DeptId { get; set; }
        public int? CourseId { get; set; }
        public List<Department>? Departments { get; set; }
        public List<Course>? Courses { get; set; }
    }
}
