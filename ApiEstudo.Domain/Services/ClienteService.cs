using ApiEstudo.Domain.Entities;
using ApiEstudo.Domain.Interfaces;
using ApiEstudo.Domain.Service;

namespace ApiEstudo.Domain.Services
{
    public class ClienteService : BaseService<Cliente>
    {
        public ClienteService(IBaseRepository<Cliente> repository) : base(repository)
        {
        }
    }
}
