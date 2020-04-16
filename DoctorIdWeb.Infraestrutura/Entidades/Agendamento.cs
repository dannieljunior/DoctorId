using DoctorIdWeb.Infraestrutura.Core;
using DoctorIdWeb.Infraestrutura.Enumerados;
using System;

namespace DoctorIdWeb.Infraestrutura.Entidades
{
    public class Agendamento: Entidade
    {
        public DateTime Data { get; set; }
        public Guid ClinicaId { get; set; }
        public Clinica Clinica { get; set; }
        public Guid? ConvenioId { get; set; }
        public Convenio Convenio { get; set; }
        public Guid PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public ESituacaoAgenda Situacao { get; set; }
    }
}
