using System.Collections.Generic;
using System.Threading.Tasks;

namespace Workshop.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        //Task<PAGINACJA<T>> FindAllPagedAsync(int? page, int? size);
        Task SaveChangesAsync();
        void CreateRange(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task CreateAsync(T entity);
        void Delete(T entity);
    }
}
