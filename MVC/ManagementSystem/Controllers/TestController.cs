using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    public class TestController : Controller
    {
        public IActionResult GetMovie(int id)
        {
            return RedirectToRoute("default");
        }
    }
}
