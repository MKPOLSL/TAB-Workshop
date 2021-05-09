using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Interfaces.Services.Base
{
    public interface IServiceBase<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        //Task<PAGINACJA<T>> FindAllPagedAsync(int? page, int? size);
        Task SaveChangesAsync();
        void CreateRange(IEnumerable<T> entities);
        void Update(T entity);
        Task CreateAsync(T entity);
        void Delete(T entity);
    }
}
