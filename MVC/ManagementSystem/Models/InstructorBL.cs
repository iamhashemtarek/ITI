namespace ManagementSystem.Models
{
    public class InstructorBL
    {
        List<Instructor> instructors;
        public InstructorBL()
        {
            Department CS = new Department() { Name = "CS" };
            Department IT = new Department() { Name = "IT" };

            instructors = new List<Instructor>()
            {
                new Instructor() { Id = 1, Name = "ali", Salary= 15000, Address = "menoufia", Image = "instructor.jpg", Department = CS },
                new Instructor() { Id = 2,Name = "ahmed", Salary= 20000, Address = "alex", Image = "instructor.jpg", Department = IT },
                new Instructor() { Id = 3,Name = "mona", Salary= 22000, Address = "cairo", Image = "instructor.jpg", Department = CS },
                new Instructor() { Id = 4,  Name = "joe", Salary= 18000, Address = "cairo", Image = "instructor.jpg", Department = IT },
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
