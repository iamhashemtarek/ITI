namespace ManagementSystem.Models
{
    public class DepartmentBL
    {
        ManagementSystemDbContext DBContext;
        public DepartmentBL()
        {
            DBContext = new ManagementSystemDbContext();
        }

        public List<Department> GetAll() => DBContext.Department.ToList();
        
    }
}
