namespace ManagementSystem.Models
{
    public class InstructorBL
    {
        
        ManagementSystemDbContext DBContext = new ManagementSystemDbContext();
        public InstructorBL()
        {

        }

        public List<Instructor> GetAll()
        {
            return DBContext.Instructors.ToList();
        }

        public Instructor GetById(int id)
        {
            return DBContext.Instructors.FirstOrDefault(instructor => instructor.Id == id);
        }
    }
}
