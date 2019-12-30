using System.ComponentModel.DataAnnotations;

namespace ApiEstudo.Web.ViewModels
{
    public class CursoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int CargaHoraria { get; set; }
    }
}
