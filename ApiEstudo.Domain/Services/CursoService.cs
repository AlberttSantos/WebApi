using ApiEstudo.Domain.Entities;
using ApiEstudo.Domain.Interfaces;
using ApiEstudo.Domain.Service;

namespace ApiEstudo.Domain.Services
{
    public class CursoService : BaseService<Curso>
    {
        public CursoService(IBaseRepository<Curso> repository) : base(repository)
        {
        }
    }
}
