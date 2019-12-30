using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiEstudo.Domain.Entities
{
    public class Curso : Entity
    {
        [StringLength(50)]
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}
