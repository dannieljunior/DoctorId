using DoctorIdWeb.Infraestrutura.Core;
using System.ComponentModel.DataAnnotations;

namespace DoctorIdWeb.Infraestrutura.Models
{
    public class ClinicaModel: ModelBase
    {
        [Required(ErrorMessage = "Campo nome é obrigatório.")]
        [MaxLength(200, ErrorMessage = "O campo nome deve ter no máximo 200 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Cnpj é obrigatório.")]
        public string Cnpj { get; set; }
        [Required(ErrorMessage = "Campo Telefone é obrigatório.")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Campo endereço é obrigatório.")]
        [MaxLength(500, ErrorMessage = "O campo endereço deve ter no máximo 500 caracteres.")]
        public string Endereco { get; set; }

    }
}