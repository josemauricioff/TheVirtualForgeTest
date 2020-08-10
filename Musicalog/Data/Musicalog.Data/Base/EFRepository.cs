using Musicalog.Entity;
using Musicalog.Data.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using System;

namespace Musicalog.Data.Base
{
    public class EFRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected MusicalogDbContext Context;

        public EFRepository(MusicalogDbContext context)
        {
            Context = context;
        }
        public ValueTask<T> GetById(int id) => Context.Set<T>().FindAsync(id);

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Context.Set<T>().ToListAsync();
        }
        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await Context.Set<T>().Where(predicate).ToListAsync();
        }
        public Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate) => Context.Set<T>().FirstOrDefaultAsync(predicate);
        public async Task<T> Add(T entity)
        {
            // await Context.AddAsync(entity);
            await Context.Set<T>().AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity;
        }
        public async Task<T> Update(T entity)
        {
            // In case AsNoTracking is used
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();

            return entity;
        }
        public async Task Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}
