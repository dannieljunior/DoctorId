using DoctorIdWeb.Infraestrutura.Core;
using DoctorIdWeb.Infraestrutura.Enumerados;
using System;

namespace DoctorIdWeb.Infraestrutura.Models
{
    public class AgendamentoModel: ModelBase
    {
        public DateTime Data { get; set; }
        public Guid ClinicaId { get; set; }
        public string ClinicaNome { get; set; }
        public Guid? Convenio { get; set; }
        public Guid PacienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string EMail { get; set; }
        public ESituacaoAgenda Situacao { get; set; }
    }
}
