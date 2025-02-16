using Core.Repositories.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : BaseApiController
    {
        private readonly IInstructorRepository instructorRepo;

        public InstructorController(IInstructorRepository instructorRepo)
        {
            this.instructorRepo = instructorRepo;
        }
    }
}
