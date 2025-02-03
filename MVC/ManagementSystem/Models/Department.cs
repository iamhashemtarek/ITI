namespace ManagementSystem.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
        public virtual ICollection<Trainee> Trainees { get; set; } = new List<Trainee>();   
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
        public int? ManagerId { get; set; }
        public virtual Instructor Manager { get; set; }
    }
}
