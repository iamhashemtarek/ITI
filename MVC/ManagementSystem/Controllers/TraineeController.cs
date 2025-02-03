using ManagementSystem.Models;
using ManagementSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    public class TraineeController : Controller
    {
        TraineeBL traineeBL = new TraineeBL();
        public IActionResult Result(int courseId, int traineeId)
        {
            TraineeResult traineeResult = traineeBL.GetCourseResultById(courseId, traineeId);

            return View("Result", traineeResult);
        }

        public IActionResult TotalResults(int traineeId) 
        {
            List<TraineeResult> traineeResults = traineeBL.getTotalResults(traineeId);

            return View("TotalResults", traineeResults);
        }
    }
}
