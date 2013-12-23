using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SugarMama.Domain.Contracts
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Query(Expression<Func<T, bool>> filter);
        T Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        void Save();
    }
}
