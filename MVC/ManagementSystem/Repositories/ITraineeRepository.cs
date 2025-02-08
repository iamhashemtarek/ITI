using ManagementSystem.Models;

namespace ManagementSystem.Repositories
{
    public interface ITraineeRepository
    {
        List<Trainee> GetAll();
        Trainee Get(int id);
        int Add(Trainee trainee);
        int Update(Trainee trainee);
        int Delete(Trainee trainee);
    }
}
