using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Contract
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        IEnumerable<Course> GetCourseByName(string name);
    }
}
