using Core.Entities;
using Core.Repositories.Contract;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
        public IEnumerable<Course> GetCourseByName(string name)
        {
            return _appDbContext.Course.Where(c => c.Name == name).ToList();
        }
    }
}
