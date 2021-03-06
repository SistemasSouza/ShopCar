using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopCar.Domain.Entities;

namespace ShopCar.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
         T Insert(T obj);

        T Update(T obj);

        T Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

        IList<T> GetAll(Expression<Func<T, bool>> predicate, string order, int skip = 0, int take = 10,
            params Expression<Func<T, object>>[] includes);

        IList<T> GetAll<TColumn>(Expression<Func<T, TColumn>> whereColumn, object whereValue, string order, int skip = 0, int take = 10, 
            params Expression<Func<T, object>>[] includes);

        IList<T> GetAll(params Expression<Func<T, object>>[] includes);

        int Count<TColumn>(Expression<Func<T, TColumn>> whereColumn, object whereValue,
            params Expression<Func<T, object>>[] includes);

        int Count(Expression<Func<T, bool>> predicate);

         void Delete(int id);

         void Commit();
    }
}