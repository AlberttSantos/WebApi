using System;
using System.ComponentModel.DataAnnotations;

namespace ApiEstudo.Domain.Entities
{
    public class Cliente : Entity
    {
        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(20)]
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Sexo { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
