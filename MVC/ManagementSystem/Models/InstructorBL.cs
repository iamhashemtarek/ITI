namespace ManagementSystem.Models
{
    public class InstructorBL
    {

        ManagementSystemDbContext DBContext;
        public InstructorBL()
        {
            DBContext = new ManagementSystemDbContext();
        }

        public List<Instructor> GetAll()
        {
            return DBContext.Instructors.ToList();
        }
        public Instructor GetById(int id)
        {
            return DBContext.Instructors.FirstOrDefault(instructor => instructor.Id == id);
        }
        public int Add(Instructor instructor)
        {
            DBContext.Instructors.Add(instructor);
            return DBContext.SaveChanges();
        }
        public int Update(Instructor instructor)
        {
            DBContext.Instructors.Update(instructor);
            return DBContext.SaveChanges();
        }
        public int Delete(Instructor instructor)
        {
            DBContext.Instructors.Remove(instructor);
            return DBContext.SaveChanges();
        }
    }
}
