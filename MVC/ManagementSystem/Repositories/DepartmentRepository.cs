using ManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ManagementSystemDbContext _dbContext;

        public DepartmentRepository()
        {
            _dbContext = new ManagementSystemDbContext();
        }
        public int Add(Department department)
        {
            _dbContext.Department.Add(department);
            return _dbContext.SaveChanges();
        }

        public int Delete(Department department)
        {
            _dbContext.Department.Remove(department);
            return _dbContext.SaveChanges();
        }

        public Department Get(int id)
        {
            return _dbContext.Department.Find(id);
        }

        public List<Department> GetAll()
        {
            return _dbContext.Department.AsNoTracking().ToList();
        }

        public int Update(Department department)
        {
            _dbContext.Department.Update(department);
            return _dbContext.SaveChanges();
        }
    }
}
