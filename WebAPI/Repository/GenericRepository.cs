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
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private protected readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public T? Get(int id)
        {
            return _appDbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _appDbContext.Set<T>().ToList();
        }

    }

}