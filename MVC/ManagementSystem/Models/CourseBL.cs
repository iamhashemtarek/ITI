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
        public Course Get(int? id) => DBContext.Courses.Find(id);
        public int Add(Course course)
        {
            DBContext.Courses.Add(course);
            return DBContext.SaveChanges();
        }
        public int Update(Course course)
        {
            DBContext.Courses.Update(course);
            return DBContext.SaveChanges();
        }
        public int Delete(Course course)
        {
            DBContext.Courses.Remove(course);
            return DBContext.SaveChanges();
        }
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
