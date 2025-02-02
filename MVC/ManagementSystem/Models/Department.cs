namespace ManagementSystem.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
        public ICollection<Trainee> Trainees { get; set; } = new List<Trainee>();   
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public int? ManagerId { get; set; }
        public Instructor Manager { get; set; }
    }
}
