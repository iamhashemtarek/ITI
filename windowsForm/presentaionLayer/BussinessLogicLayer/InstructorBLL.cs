using dataAccessLayer;
using Models;
using System.Data;

namespace BussinessLogicLayer
{
    public class InstructorBLL
    {
        InstructorDAL instructorDAL;

        public InstructorBLL(string connectionString)
        {
            instructorDAL = new InstructorDAL(connectionString);    
        }

        public DataTable getAllInstructors() 
        {
            return instructorDAL.getAllInstructors();
        }
        public void addInstructor(Instructor instructor, DataTable dt)
        {
            instructorDAL.addInstructor(instructor, dt);
        }

        public void updateInstructor(Instructor instructor, DataTable dt)
        {
            instructorDAL.updataInstructor(instructor, dt);
        }

        public void deleteInstructor(int instructorId, DataTable dt)
        {
            instructorDAL.deleteInstructor(instructorId, dt);
        }
        public void updateDatabase(DataTable dt)
        {
            instructorDAL.UpdateDatabase(dt);   
        }
    }
}
