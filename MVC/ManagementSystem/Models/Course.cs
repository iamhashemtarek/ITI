namespace ManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        public int Hours {  get; set; }

        public virtual ICollection<CourseResult> CourseResults { get; set; } = new List<CourseResult>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
        public int DeptId {  get; set; }    
        public virtual Department Department { get; set; }
    }
}
