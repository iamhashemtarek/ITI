namespace ManagementSystem.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address {  get; set; }
        public string Image {  get; set; }

        public int? DeptId { get; set; }
        public virtual Department Department { get; set; }

        public int CourseId { get; set; }   
        public virtual Course Course { get; set; }
    }
}
