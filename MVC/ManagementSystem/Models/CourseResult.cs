namespace ManagementSystem.Models
{
    public class CourseResult
    {
        public int Id { get; set; }
        public int Degree { get; set; }

        public int TraineeId {  get; set; }
        public virtual Trainee Trainee { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
