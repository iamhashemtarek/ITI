using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;

namespace Talabat.Core.Specifications
{
    public class ProductWithBrandAndCategorySpecification : Specification<Product>
    {
        public ProductWithBrandAndCategorySpecification():base()
        {
            _AddIncludes();
        }

        public ProductWithBrandAndCategorySpecification(int id)
            :base(p => p.Id ==  id)
        {
            _AddIncludes();
        }

        private void _AddIncludes()
        {
            Includes.Add(p => p.ProductBrand);
            Includes.Add(p => p.ProductCategory);
        }
    }
}
