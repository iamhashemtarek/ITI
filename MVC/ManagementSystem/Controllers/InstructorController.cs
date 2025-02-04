using ManagementSystem.Models;
using ManagementSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    public class InstructorController : Controller
    {
        ManagementSystemDbContext DBContext = new ManagementSystemDbContext();
        InstructorBL instructorBL = new InstructorBL();
        DepartmentBL departmentBL = new DepartmentBL();
        CourseBL courseBL = new CourseBL();
        public IActionResult Index()
        {
            List<Instructor> instructors = instructorBL.GetAll();

            return View("Index", instructors);
        }
        public IActionResult Details(int id)
        {
            Instructor instructor = instructorBL.GetById(id);

            return View("Details", instructor);
        }
        public IActionResult Edit(int id)
        {
            Instructor instructor = instructorBL.GetById(id);
            List<Department> departments = departmentBL.GetAll();

            InstructorWithDeptsAndWithCourses instructorWDepts = new InstructorWithDeptsAndWithCourses()
            {
                Id = instructor.Id,
                Name = instructor.Name,
                Salary = instructor.Salary,
                Address = instructor.Address,
                Image = instructor.Image,
                DeptId = instructor.DeptId,
                CourseId = instructor.CourseId,
                Departments = departments
            };
            return View("Edit", instructorWDepts);
        }
        public IActionResult New()
        {
            List<Department> departments = departmentBL.GetAll();
            List<Course> courses = courseBL.GetAll();

            InstructorWithDeptsAndWithCourses instructorWDeptsAndCourses = new InstructorWithDeptsAndWithCourses()
            {
                Departments = departments,
                Courses = courses
            };

            return View("New", instructorWDeptsAndCourses);
        }
        public IActionResult SaveNew(Instructor newInstructor)
        {
            if (newInstructor != null)
            {
                newInstructor.Image = "instructor.jpg";
                DBContext.Instructors.Add(newInstructor);
                DBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("New", newInstructor);
        }
    }
}
