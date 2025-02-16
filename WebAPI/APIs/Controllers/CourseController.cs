using Core.Entities;
using Core.Repositories.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIs.Controllers
{
    public class CourseController : BaseApiController
    {
        private readonly ICourseRepository _courseRepo;

        public CourseController(ICourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetAll()
        {

            var courses = _courseRepo.GetAll();

            return Ok(courses);
        }


        [HttpGet("{id:int}")]
        public ActionResult<Course> Get(int id)
        {
            var course = _courseRepo.Get(id);

            if (course is null)
                return NotFound();

            return Ok(course);
        }



        [HttpGet("byname")]
        public ActionResult<Course> GetByName([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return BadRequest("Name parameter is required.");

            var course = _courseRepo.GetCourseByName(name);

            if (course is null)
                return NotFound();

            return Ok(course);
        }
    }
}
