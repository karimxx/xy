﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface ISpecifications<T>
    {
        Expression<Func<T, bool>> Condition { get; }
        List<Expression<Func<T, object>>> Values { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDes { get; }
        int Take { get; }   
        int Skip { get; }
        bool IsPagingEnabled { get; }   

    }
}
