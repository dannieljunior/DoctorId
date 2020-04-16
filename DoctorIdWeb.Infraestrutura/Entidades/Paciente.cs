using DoctorIdWeb.Infraestrutura.Core;
using System.Collections.Generic;

namespace DoctorIdWeb.Infraestrutura.Entidades
{
    public class Paciente: Entidade
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public List<Agendamento> Agendamentos { get; set; }
    }
}
