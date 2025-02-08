using ManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Repositories
{
    public class TraineeRepository : ITraineeRepository
    {
        private readonly ManagementSystemDbContext _dbContext;

        public TraineeRepository()
        {
            _dbContext = new ManagementSystemDbContext();
        }
        public int Add(Trainee trainee)
        {
            _dbContext.Trainees.Add(trainee);
            return _dbContext.SaveChanges();
        }

        public int Delete(Trainee trainee)
        {
            _dbContext.Trainees.Remove(trainee);
            return _dbContext.SaveChanges();
        }

        public Trainee Get(int id)
        {
            return _dbContext.Trainees.Find(id);
        }

        public List<Trainee> GetAll()
        {
            return _dbContext.Trainees.AsNoTracking().ToList();
        }

        public int Update(Trainee trainee)
        {
            _dbContext.Trainees.Update(trainee);
            return _dbContext.SaveChanges();
        }
    }
}
