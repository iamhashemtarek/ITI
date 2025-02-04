using ManagementSystem.ViewModel;

namespace ManagementSystem.Models
{
    public class CourseBL
    {
        ManagementSystemDbContext DBContext;

        public CourseBL()
        {
            DBContext = new ManagementSystemDbContext();
        }

        public List<Course> GetAll() => DBContext.Courses.ToList(); 
        public List<ResultsPerCourse> GetAllResults(int courseId)
        {
            List<ResultsPerCourse> resultsPerCourse = new List<ResultsPerCourse>();

            var all = DBContext.CoursesResult.Where(c => c.CourseId == courseId).ToList();
            foreach (var item in all)
            {
                resultsPerCourse.Add(new ResultsPerCourse
                {
                    CourseName = item.Course.Name,
                    TraineeId = item.Trainee.Id,
                    TraineeName = item.Trainee.Name,
                    Degree = item.Degree,
                    status = item.Degree >= item.Course.MinDegree ? true : false,
                    
                });

            }

            return resultsPerCourse;
        }
    }
}
