using ManagementSystem.ViewModel;

namespace ManagementSystem.Models
{
    public class TraineeBL
    {
        ManagementSystemDbContext DBContext;
        public TraineeBL()
        {
            DBContext = new ManagementSystemDbContext();
        }

        public TraineeResult GetCourseResultById(int courseId, int traineeId)
        {
            var courseResult = DBContext.CoursesResult.FirstOrDefault(cr => cr.TraineeId == traineeId && cr.CourseId == courseId);

            TraineeResult traineeResult = new TraineeResult()
            {
                TraineeId = courseResult?.Trainee?.Id,
                TraineeName = courseResult?.Trainee?.Name,
                CourseName = courseResult?.Course?.Name,
                Degree =  courseResult?.Degree,
                status = courseResult?.Degree >= courseResult?.Course?.MinDegree ? true : false,
            };

            return traineeResult;
        }

        public List<TraineeResult> getTotalResults(int traineeId)
        {
            
            List<TraineeResult> traineeResults = new List<TraineeResult>();
            var CoursesReults = DBContext.CoursesResult.Where(cr => cr.TraineeId == traineeId).ToList();

            foreach (var item in CoursesReults)
            {
                traineeResults.Add(new TraineeResult()
                {
                    TraineeId = item.Trainee?.Id,
                    TraineeName = item.Trainee?.Name,
                    CourseName = item.Course?.Name,
                    Degree = item.Degree,
                    status = item.Degree >= item.Course?.MinDegree ? true : false,
                });
            }

            return traineeResults;
        }
    }
}
