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
        public ProductWithBrandAndCategorySpecification(ProductSpecParams productSpec) :
            base(p => 
                    (!productSpec.BrandId.HasValue || p.ProductBrandId == productSpec.BrandId.Value) &&
                                (!productSpec.CategoryId.HasValue || p.ProductCategoryId == productSpec.CategoryId.Value)
            )
        {
            _AddIncludes();

            if (!String.IsNullOrEmpty(productSpec.Sort))
            {
                switch (productSpec.Sort)
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

            if (productSpec.PageIndex.HasValue && productSpec.PageSize.HasValue)
            {
                Skip = (productSpec.PageIndex.Value - 1) * productSpec.PageSize.Value;
                Take = productSpec.PageSize.Value;
            }
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
