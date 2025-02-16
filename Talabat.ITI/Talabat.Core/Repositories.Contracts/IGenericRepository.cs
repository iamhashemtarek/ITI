using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;
using Talabat.Core.Specifications;

namespace Talabat.Core.Repositories.Contracts
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllWithSpecAsync(ISpecification<T> spec);
        Task<T?> GetWithSpecAsync(ISpecification<T> spec);
        //Task<T> AddAsync(T entity);
        //Task UpdateAsync(T entity);
        //Task DeleteAsync(T entity);
    }
}
