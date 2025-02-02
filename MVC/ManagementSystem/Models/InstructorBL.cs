namespace ManagementSystem.Models
{
    public class InstructorBL
    {
        List<Instructor> instructors;

        public InstructorBL()
        {
            instructors = new List<Instructor>()
            {
                new Instructor() { Name = "ali", Salary= 15000, Address = "menoufia", Image = "instructor.png" },
                new Instructor() { Name = "ahmed", Salary= 20000, Address = "alex", Image = "instructor.png" },
                new Instructor() { Name = "mona", Salary= 22000, Address = "cairo", Image = "instructor.png" },
                new Instructor() { Name = "joe", Salary= 18000, Address = "cairo", Image = "instructor.png" },
            };
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetById(int id)
        {
            return instructors.FirstOrDefault(instructor => instructor.Id == id);
        }
    }
}
