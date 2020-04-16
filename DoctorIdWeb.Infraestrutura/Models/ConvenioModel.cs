using DoctorIdWeb.Infraestrutura.Core;
using System.ComponentModel.DataAnnotations;

namespace DoctorIdWeb.Infraestrutura.Models
{
    public class ConvenioModel: ModelBase
    {
        [Required(ErrorMessage = "Campo nome obrigatório.")]
        [MaxLength(200, ErrorMessage = "O campo nome deve ter no máximo 200 caracteres.")]
        public string Nome { get; set; }
    }
}
