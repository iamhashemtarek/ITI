using Core.Repositories.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : BaseApiController
    {
        private readonly IStudentRepository _studentRepo;

        public StudentController(IStudentRepository studentRepo)
        {
           _studentRepo = studentRepo;
        }
    }
}
