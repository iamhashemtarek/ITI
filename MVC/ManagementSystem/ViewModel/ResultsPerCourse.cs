namespace ManagementSystem.ViewModel
{
    public class ResultsPerCourse
    {
        public string CourseName { get; set; }
        public int? TraineeId { get; set; }
        public string? TraineeName { get; set; }
        public int? Degree { get; set; }
        public  bool? status { get; set; } = false;
    }
}
