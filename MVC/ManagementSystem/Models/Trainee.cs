namespace ManagementSystem.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Grade { get; set; }
        public string Image {  get; set; }
        public int? DeptId { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<CourseResult> CourseResults { get; set; } = new List<CourseResult>();
    }
}
