using ApiEstudo.Data.Context;
using ApiEstudo.Domain.Entities;
using ApiEstudo.Domain.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEstudo.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        private readonly ApiEstudoContext _context;

        public BaseRepository(ApiEstudoContext context)
        {
            _context = context;
        }

        public IQueryable<T> Query => _context.Set<T>().AsQueryable();

        public virtual async Task<T> AddAsync(T entity)
        {
            var result = await _context.Set<T>().AddAsync(entity);
            return result.Entity;
        }

        public virtual async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(T entity)
        {
            var result = _context.Set<T>().Remove(entity);
            return Task.FromResult(result);
        }

        public virtual Task<T> UpdateAsync(T entity)
        {
            var result = _context.Set<T>().Update(entity);
            return Task.FromResult(result.Entity);
        }
    }
}
