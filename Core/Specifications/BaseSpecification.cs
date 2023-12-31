using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get; }

        public List<Expression<Func<T, object>>> Includes { get; } = new();

        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            this.Criteria = criteria;
        }

        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression); 
        }
    }
}