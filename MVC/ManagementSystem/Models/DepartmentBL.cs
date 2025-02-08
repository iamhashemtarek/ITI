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
        public Department Get(int id) => DBContext.Department.Find(id);
        public int Add(Department department)
        {
            DBContext.Department.Add(department);
            return DBContext.SaveChanges();
        }
        public int Update(Department department)
        {
            DBContext.Department.Update(department);
            return DBContext.SaveChanges();
        }
        public int Delete(Department department)
        {
            DBContext.Department.Remove(department);
            return DBContext.SaveChanges();
        }

    }
}
