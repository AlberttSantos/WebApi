using ApiEstudo.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEstudo.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : Entity
    {
        IQueryable<T> Query { get; }
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task CommitAsync();
    }
}
