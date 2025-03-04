using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core;
using Talabat.Core.Entities;
using Talabat.Core.Repositories.Contracts;
using Talabat.Repository.Data;

namespace Talabat.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreContext _storeContext;
        public Hashtable _repositories;
        public UnitOfWork(StoreContext storeContext)
        {
            _storeContext = storeContext;
            _repositories = new Hashtable();
        }


        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            var key = typeof(TEntity).Name; 
            if(!_repositories.ContainsKey(key))
            {
                var repository = new GenericRepository<TEntity>(_storeContext);
                _repositories.Add(key, repository);
            }

            return _repositories[key] as IGenericRepository<TEntity>;
        }

        public async Task<int> SaveChangesAsync() =>  await _storeContext.SaveChangesAsync();
        public async ValueTask DisposeAsync() => await _storeContext.DisposeAsync();
    }
}
