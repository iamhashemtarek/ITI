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
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
    }
}
