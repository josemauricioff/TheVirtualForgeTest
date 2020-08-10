using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Musicalog.Entity;

namespace Musicalog.Data.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        ValueTask<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Remove(T entity);
    }
}
