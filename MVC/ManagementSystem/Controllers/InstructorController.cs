using ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    public class InstructorController : Controller
    {
        InstructorBL instructorBL = new InstructorBL();
        public IActionResult All()
        {
            List<Instructor> instructors = instructorBL.GetAll();

            return View(instructors);
        }
        public IActionResult Details(int id)
        {
            Instructor instructor = instructorBL.GetById(id);

            return View(instructor);
        }
    }
}
