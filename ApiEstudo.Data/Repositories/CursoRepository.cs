using ApiEstudo.Data.Context;
using ApiEstudo.Domain.Entities;

namespace ApiEstudo.Data.Repositories
{
    public class CursoRepository : BaseRepository<Curso>
    {
        public CursoRepository(ApiEstudoContext context) : base(context)
        {
        }
    }
}
