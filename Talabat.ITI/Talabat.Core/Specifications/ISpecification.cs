using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;

namespace Talabat.Core.Specifications
{
    public interface ISpecification<T> where T : BaseEntity
    {
        public Expression<Func<T, bool>> Criteria { get; set; }
        public List<Expression<Func<T, Object>>> Includes { get; set; }
        public Expression<Func<T, Object>> OrderBy { get; set; }
        public Expression<Func<T, Object>> OrderByDesc { get; set; }
    }
}
