using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;

namespace Talabat.Core.Specifications
{    public class ProductWithBrandAndCategorySpecification : Specification<Product>
    {
        public ProductWithBrandAndCategorySpecification(string? sort, int? brandId, int? categoryId) :
            base(p => 
                    (!brandId.HasValue || p.ProductBrandId == brandId.Value) &&
                                (!categoryId.HasValue || p.ProductCategoryId == categoryId.Value)
            )
        {
            _AddIncludes();

            if (!String.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDesc(p => p.Price);
                        break;
                    default:
                        AddOrderBy(p => p.Name);
                        break;
                }
            }else 
                AddOrderBy(p => p.Name);
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
