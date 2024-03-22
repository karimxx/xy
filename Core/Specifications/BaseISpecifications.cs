﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class BaseISpecifications<T> : ISpecifications<T>
    {
        public BaseISpecifications()
        {
           

        }
        public BaseISpecifications(Expression<Func<T, bool>> condition)
        {
            Condition = condition;
    
        }

        public Expression<Func<T, bool>> Condition { get; }

        public List<Expression<Func<T, object>>> Values { get; } = new List<Expression<Func<T, object>>>();

        public Expression<Func<T, object>> OrderBy { get; private set; }

        public Expression<Func<T, object>> OrderByDes { get; private set; }

        public int Take  { get; private set; }

    public int Skip { get; private set; }

    public bool IsPagingEnabled { get; private set; }

        protected void AddInclude(Expression<Func<T, object>> includeExpressions)
        {
            Values.Add(includeExpressions); 
        }
        public void AddOrderBy(Expression<Func<T, object>> OrderByExpression)
        {
            OrderBy = OrderByExpression;
        }

        public void AddOrderByDesc(Expression<Func<T, object>> OrderByDescExpression)
        {
            OrderByDes = OrderByDescExpression;
        }
        protected void ApplyingPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled= true;  
        }

    }
}
