using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Entities;
using Workshop.Interfaces.Services.Base;
using Workshop.Utils;

namespace Workshop.Services.Base
{
    public class ServiceBase<T> : IServiceBase<T> where T : HideableEntity
    {
        protected CarContext Context { get; set; }

        protected ServiceBase(CarContext context) => Context = context;

        public virtual async Task CreateAsync(T entity)
        {
            await Context
                 .Set<T>()
                 .AddAsync(entity);
        }

        public virtual void CreateRange(IEnumerable<T> entities)
        {
            Context
                .Set<T>()
                .AddRange(entities);
        }

        public virtual void Delete(T entity)
        {
            Context
                .Set<T>()
                .Remove(entity);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            IQueryable<T> set = Context
                .Set<T>()
                .GetAllNotHidden();
            return await set.ToListAsync();
        }

        public virtual async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

        public virtual void Update(T entity)
        {
            Context
                 .Set<T>()
                 .Update(entity);
        }
    }
}
