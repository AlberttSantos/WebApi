using ApiEstudo.Data.Context;
using ApiEstudo.Domain.Entities;

namespace ApiEstudo.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>
    {
        public ClienteRepository(ApiEstudoContext context) : base(context)
        {
        }
    }
}
