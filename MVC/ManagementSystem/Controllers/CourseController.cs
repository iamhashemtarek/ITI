using ManagementSystem.Models;
using ManagementSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        CourseBL courseBl = new CourseBL();
        public IActionResult Results(int courseId)
        {
            List<ResultsPerCourse> results = courseBl.GetAllResults(courseId);


            return View("Results", results);
        }
    }
}
