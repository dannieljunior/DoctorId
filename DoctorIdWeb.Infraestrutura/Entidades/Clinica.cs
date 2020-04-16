using DoctorIdWeb.Infraestrutura.Core;
using System.Collections.Generic;

namespace DoctorIdWeb.Infraestrutura.Entidades
{
    public class Clinica: Entidade
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public List<Agendamento> Agendamentos { get; set; }
    }
}