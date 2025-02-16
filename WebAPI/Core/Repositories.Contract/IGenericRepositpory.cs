using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Contract
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T? Get(int id);
        IEnumerable<T> GetAll();
    }
}
