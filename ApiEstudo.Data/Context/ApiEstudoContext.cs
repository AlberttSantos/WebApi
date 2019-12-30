using ApiEstudo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiEstudo.Data.Context
{
    public class ApiEstudoContext : DbContext
    {
        public ApiEstudoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Curso> Curso { get; set; }
    }
}
