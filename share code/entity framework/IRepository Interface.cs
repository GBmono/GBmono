using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MyNameSpance.Data
{
    public interface IRepository<T>
    {
        // CRUD
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        void Save();

        void Copy(T source, T target);

        T Get(int id);
        T Get(Expression<Func<T, bool>> predicate);

        IQueryable<T> Table { get; }

        int Count(Expression<Func<T, bool>> predicate);
        IEnumerable<T> Fetch(Expression<Func<T, bool>> predicate);
    }
}