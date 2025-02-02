namespace ManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        public int Hours {  get; set; }

        public ICollection<CourseResult> CourseResults { get; set; } = new List<CourseResult>();
        public int DeptId {  get; set; }    
        public Department Department { get; set; }
    }
}
