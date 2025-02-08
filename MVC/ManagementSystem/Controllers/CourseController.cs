using ManagementSystem.Models;
using ManagementSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        ManagementSystemDbContext _context;

        CourseBL courseBl = new CourseBL();
        public CourseController()
        {
            _context = new ManagementSystemDbContext();
        }

        public IActionResult Results(int courseId)
        {
            List<ResultsPerCourse> results = courseBl.GetAllResults(courseId);


            return View("Results", results);
        }

        public IActionResult Index() 
        {
            var courses = courseBl.GetAll();
            return View(courses);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id is null)
                return BadRequest();

            var course = courseBl.Get(id);
            if(course is null)
                return NotFound();

         

            var model = new CourseWithDepartmentViewModel
            {
                Id = course.Id,
                Name = course.Name,
                Degree = course.Degree,
                MinDegree = course.MinDegree,
                Hours = course.Hours,
                DeptId = course.DeptId,
                DepartmentList = _context.Department.Any()
                   ? new SelectList(_context.Department, "Id", "Name", course.DeptId)
                   : new SelectList(new List<Department>())
            };

            return View("Edit", model);
        }
        [HttpPost]
        public IActionResult Edit(int? id, CourseWithDepartmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.DepartmentList = new SelectList(_context.Department, "Id", "Name", model.DeptId);
                return View("Edit",model);
            }

            var course = courseBl.Get(id);
            if (course == null)
            {
                return NotFound();
            }
            course.Name = model.Name;
            course.Degree = model.Degree;
            course.MinDegree = model.MinDegree;
            course.Hours = model.Hours;
            course.DeptId = model.DeptId;

            courseBl.Update(course);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var course = courseBl.Get(id);
            if (course == null)
            {
                return NotFound();
            }

            courseBl.Delete(course);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var course = courseBl.Get(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        [HttpGet]
        public IActionResult Create()
        {

            var model = new CourseWithDepartmentViewModel
            {
                DepartmentList = _context.Department.Any()
                   ? new SelectList(_context.Department, "Id", "Name")
                   : new SelectList(new List<Department>())
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult Create(CourseWithDepartmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.DepartmentList = new SelectList(_context.Department, "Id", "Name", model.DeptId);
                return View("Edit", model);
            }
                Course course = new Course();
                course.Name = model.Name;
                course.Degree = model.Degree;
                course.MinDegree = model.MinDegree;
                course.Hours = model.Hours;
                course.DeptId = model.DeptId;

                courseBl.Add(course);

                return RedirectToAction("Index");
            
        }
    }
}
