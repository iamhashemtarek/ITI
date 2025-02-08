using ManagementSystem.Models;

namespace ManagementSystem.Repositories
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();
        Department Get(int id);
        int Add(Department department);
        int Update(Department department);
        int Delete(Department department);
    }
}
