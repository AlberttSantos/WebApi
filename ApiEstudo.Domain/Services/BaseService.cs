using System.Linq;
using System.Threading.Tasks;
using ApiEstudo.Domain.Entities;
using ApiEstudo.Domain.Interfaces;

namespace ApiEstudo.Domain.Service
{
    public class BaseService<T> : IBaseService<T> where T : Entity
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public IQueryable<T> Query => _repository.Query;

        public async Task<T> AddAsync(T entity)
        {
            var e = await _repository.AddAsync(entity);
            await _repository.CommitAsync();

            return e;
        }

        public async Task DeleteAsync(T entity)
        {
            await _repository.DeleteAsync(entity);
            await _repository.CommitAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var e = await _repository.UpdateAsync(entity);
            await _repository.CommitAsync();

            return e;
        }
    }
}
