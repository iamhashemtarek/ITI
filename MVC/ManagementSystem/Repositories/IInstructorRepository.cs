using ManagementSystem.Models;

namespace ManagementSystem.Repositories
{
    public interface IInstructorRepository
    {
        List<Instructor> GetAll();
        Instructor Get(int id);
        int Add(Instructor instructor);
        int Update(Instructor instructor);
        int Delete(Instructor instructor);
    }
}
