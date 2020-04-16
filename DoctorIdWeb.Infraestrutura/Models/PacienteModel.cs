using DoctorIdWeb.Infraestrutura.Core;
using System.ComponentModel.DataAnnotations;

namespace DoctorIdWeb.Infraestrutura.Models
{
    public class PacienteModel: ModelBase
    {
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Cpf é obrigatório.")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string Email { get; set; }
    }
}
