using ManagementSystem.Models;

namespace ManagementSystem.Repositories
{
    public interface ICourseRepository
    {
        List<Course> GetAll();
        Course Get(int id);
        int Add(Course course);
        int Update(Course course);
        int Delete(Course course);
    }
}
