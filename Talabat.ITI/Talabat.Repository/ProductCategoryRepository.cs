using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;
using Talabat.Core.Repositories.Contracts;
using Talabat.Repository.Data;

namespace Talabat.Repository
{
    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(StoreContext storeContext) : base(storeContext)
        {
        }
    }
}
